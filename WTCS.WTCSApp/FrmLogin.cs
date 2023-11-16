using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WTCS.BLL;

namespace WTCS.WTCSApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            userName.Clear();
            userPwd.Clear();
        }

        /// <summary>
        /// 登录过程处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //接收页面输入
            string uName = userName.Text.Trim();
            string uPwd = userPwd.Text.Trim();
            //检查信息 --- 非空检查

            if (string.IsNullOrEmpty(uName) || string.IsNullOrEmpty(uPwd))
            {
                MsgBoxHelper.MsgErrorShow("登陆系统", "账号或密码为空！");
                return;
            }

            //登录检查---检查用户是否存在
            UserBLL userBLL = new UserBLL();

            bool isUserExsist = userBLL.LoginSystem(uName, uPwd);

            //检查结果，作处理：存在 ---成功，显示主页面；不存在，中断提示

            if (isUserExsist)
            {
                //显示系统主页
                FrmMain frmMain = new FrmMain();
                frmMain.Tag = uName;
                frmMain.Show();
                Hide();
                return;
            }
            else
            {
                MsgBoxHelper.MsgErrorShow("登录系统", "用户不存在或密码错误!");
                return;
            }
        }


        /// <summary>
        /// 登录窗口关闭事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MsgBoxHelper.MsgBoxConfirm("退出系统", "您确认要退出系统吗？") == DialogResult.Yes)
            {
                //消息循环
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }


        }
    }
}
