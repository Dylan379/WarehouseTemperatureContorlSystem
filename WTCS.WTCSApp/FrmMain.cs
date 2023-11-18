using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WTCS.WTCSApp.UControls;

namespace WTCS.WTCSApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        System.Timers.Timer timer = null;


        #region 左侧导航栏点击处理事件
        private void ClickBtnStoreManage(object sender, EventArgs e)
        {
            ShowStoreManage();
        }
        private void ClickBtnProductManage(object sender, EventArgs e)
        {
            SetModuleBtnBackColor(2);
            product.FormProductList formProductList = new product.FormProductList();
            panelPage.AddFormToPanel(formProductList);
        }

        private void ClickBtnStoreTemperManage(object sender, EventArgs e)
        {
            SetModuleBtnBackColor(3);
            storeTemper.FormStoreRegionTemperList formStoreRegionTemperList = new storeTemper.FormStoreRegionTemperList();
            panelPage.AddFormToPanel(formStoreRegionTemperList);
        }

        private void SetModuleBtnBackColor(int code)
        {
            switch (code)
            {
                case 1:
                    SetMenuBtnsColor(btnStoreManage, btnStorePage);
                    break;
                case 2:
                    SetMenuBtnsColor(btnProductManage, btnProductManagePage);
                    break;
                case 3:
                    SetMenuBtnsColor(btnStoreTemperManage, btnStoreTemperPage);
                    break;
                default:
                    break;
            }
        }

        private void SetMenuBtnsColor(UMenuButton btn, UPageButton btnPage)
        {
            Color unSelColor = Color.FromArgb(45, 50, 116);
            Color selColor = Color.FromArgb(88, 116, 216);
            //分页按钮背景颜色
            Color topUnSelColor = Color.White;
            Color topSelColor = Color.FromArgb(45, 50, 116);

            btn.BackColor = selColor;
            btnPage.ForeColor = topSelColor;

            UMenuButton[] uMenuButtons = { btnStoreManage, btnProductManage, btnStoreTemperManage };
            UPageButton[] uPageButtons = { btnStorePage, btnStoreRegionPage, btnProductManagePage, btnProductInStorePage, btnStoreTemperPage };

            foreach (UMenuButton item in uMenuButtons)
            {
                if (item.Name != btn.Name)
                {
                    btn.BackColor = unSelColor;
                }
            }

            foreach (UPageButton item in uPageButtons)
            {
                if (item.Name != btnPage.Name)
                {
                    btnPage.BackColor = topUnSelColor;
                }
            }
            //颜色处理
        }
        #endregion

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                btnMax.Text = "1";
                WindowState = FormWindowState.Normal;
            }
            else
            {
                btnMax.Text = "2";
                WindowState = FormWindowState.Maximized;
            }
        }

        /// <summary>
        /// 关闭即退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 窗口关闭处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MsgBoxHelper.MsgBoxConfirm("退出系统", "您确认要退出系统吗？") == DialogResult.Yes)
            {
                //消息循环
                if (timer != null)
                    timer.Stop();
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (Tag != null)
            {
                //状态栏信息的初始化
                InitStatusInfo();
                //显示仓库管理页面
                ShowStoreManage();
                btnStorePage.Visible = true;
            }
        }

        /// <summary>
        /// 显示仓库管理页面
        /// </summary>
        private void ShowStoreManage()
        {
            SetModuleBtnBackColor(1);
            store.FormStoreList formStoreList = new store.FormStoreList();
            panelPage.AddFormToPanel(formStoreList);

        }


        /// <summary>
        /// 状态栏信息初始化处理
        /// </summary>
        private void InitStatusInfo()
        {
            string uName = Tag.ToString();
            loginUserName.Text = uName;

            //时间
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.AutoReset = true;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                dayTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }));
        }

        private void btnProductManage_Click(object sender, EventArgs e)
        {

        }

        private void btnStoreTemperManage_Click(object sender, EventArgs e)
        {

        }


    }
}
