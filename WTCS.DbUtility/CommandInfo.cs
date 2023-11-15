using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTCS.DbUtility
{
    public class CommandInfo
    {

        public string CommandText;//sql语句或存储过程
        public SqlParameter[] Paras;//参数列表
        public bool IsProc;//是否是存储过程

        public CommandInfo()
        {

        }

        public CommandInfo(string comText, bool isProc)
        {
            this.CommandText = comText;
            this.IsProc = isProc;
        }

        public CommandInfo(string comText, bool isProc, SqlParameter[] paras)
        {
            this.CommandText = comText;
            this.IsProc = isProc;
            this.Paras = paras;
        }

    }
}
