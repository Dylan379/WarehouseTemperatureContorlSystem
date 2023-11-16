using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WTCS.WTCSApp
{
    public class MsgBoxHelper
    {

        /// <summary>
        /// 基础消息提示框  操作成功提示框
        /// </summary>
        /// <param name="title"></param>
        /// <param name="Msg"></param>
        /// <returns></returns>
        public static DialogResult MsgBoxShow(string title, string Msg)
        {
            return MessageBox.Show(Msg,
                                   title,
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
        }

        /// <summary>
        /// 基础消息提示框  操作成功提示框
        /// </summary>
        /// <param name="title"></param>
        /// <param name="Msg"></param>
        /// <returns></returns>
        public static DialogResult MsgBoxConfirm(string title, string Msg)
        {
            return MessageBox.Show(Msg,
                                   title,
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);
        }

        /// <summary>
        /// 基础消息提示框 错误消息
        /// </summary>
        /// <param name="title"></param>
        /// <param name="Msg"></param>
        /// <returns></returns>
        public static DialogResult MsgErrorShow(string title, string Msg)
        {
            return MessageBox.Show(Msg,
                                   title,
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
        }

    }
}
