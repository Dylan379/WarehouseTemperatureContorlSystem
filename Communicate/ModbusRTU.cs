using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communicate
{
    public class ModbusRTU : SerialPortBase
    {
        /// <summary>
        /// 创建对象
        /// </summary>
        /// <param name="portName"></param>
        /// <param name="baudRate"></param>
        /// <param name="dataBits"></param>
        /// <param name="stopBits"></param>
        /// <param name="parity"></param>
        public ModbusRTU(string portName,
                         int baudRate,
                         int dataBits,
                         StopBits stopBits,
                         Parity parity) : base(portName, baudRate, dataBits, stopBits, parity)
        { }


        public override async Task<List<ushort>> ReadUInt16(byte startAddr, byte deviceAddr = 1, byte funcCode = 3, ushort len = 1)
        {
            //拼装请求报文
            List<byte> readBytes = GetReadCommandBytes(deviceAddr, funcCode, startAddr, len);

            readBytes = CRC16(readBytes);
            List<byte> responseBytes = await Send(readBytes, len);
            if (responseBytes.Count > 0)
            {
                responseBytes.RemoveRange(0, 3);
                responseBytes.RemoveRange(responseBytes.Count - 2, 2);
                return ReadUInt16(responseBytes);
            }
            return null;

        }

        /// <summary>
        /// 写单寄存器
        /// </summary>
        /// <param name="startAddr"></param>
        /// <param name="val"></param>
        /// <param name="deviceAddr"></param>
        /// <param name="funcCode"></param>
        /// <returns></returns>
        public override async Task<bool> WriteUInt16(int startAddr, ushort val, byte deviceAddr = 1, byte funcCode = 6)
        {
            List<byte> commandBytes = GetWriteCommandBytes(deviceAddr, funcCode, startAddr, val);
            commandBytes = CRC16(commandBytes);
            List<byte> respBytes = await Send(commandBytes, 0);
            if (respBytes.Count == commandBytes.Count)
                return true;
            else
                return false;
        }


        private List<byte> CRC16(List<byte> value, ushort poly = 0xA001, ushort crcInit = 0xFFFF)
        {
            if (value == null || !value.Any())
                throw new ArgumentException("");

            //运算
            ushort crc = crcInit;
            for (int i = 0; i < value.Count; i++)
            {
                crc = (ushort)(crc ^ (value[i]));
                for (int j = 0; j < 8; j++)
                {
                    crc = (crc & 1) != 0 ? (ushort)((crc >> 1) ^ poly) : (ushort)(crc >> 1);
                }
            }
            byte hi = (byte)((crc & 0xFF00) >> 8);  //高位置
            byte lo = (byte)(crc & 0x00FF);         //低位置

            List<byte> buffer = new List<byte>();
            buffer.AddRange(value);
            buffer.Add(lo);
            buffer.Add(hi);
            return buffer;
        }

    }
}
