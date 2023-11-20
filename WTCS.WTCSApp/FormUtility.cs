using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WTCS.WTCSApp
{
    public static class FormUtility
    {

        /// <summary>
        /// 检查Form是否被打开
        /// </summary>
        /// <param name="formName">form名称</param>
        /// <returns></returns>
        public static bool IsFormOpen(string formName)
        {
            bool isOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == formName)
                {
                    isOpen = true;
                    break;
                }
            }
            return isOpen;
        }

        /// <summary>
        /// 通过form名称得到打开的form
        /// </summary>
        /// <param name="formName">已打开的form名称</param>
        /// <returns></returns>
        public static Form GetOpenForm(string formName)
        {
            Form targetForm = null;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == formName)
                {
                    targetForm = form;
                    break;
                }
            }
            return targetForm;
        }

        /// <summary>
        /// 判断打开的form是否在指定Panel中
        /// </summary>
        /// <param name="formName">已打开的form名称</param>
        /// <param name="panel">指定panel</param>
        /// 
        /// <returns></returns>
        public static bool IsOpenedFormInPanel(Form form, Panel panel)
        {
            bool isInPanel = false;
            foreach (Control item in panel.Controls)
            {
                if (item is Form)
                {
                    Form formItem = item as Form;
                    if (formItem.Name == form.Name)
                    {
                        isInPanel = true;
                        //form = formItem;
                        break;
                    }
                }
            }
            return isInPanel;
        }


        /// <summary>
        /// 将指定form显示到panel中
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="form"></param>
        public static void AddFormToPanel(this Panel panel, Form form)
        {
            //先检查一个Form是否被打开
            if (IsFormOpen(form.Name))
            {
                Form openForm = GetOpenForm(form.Name);
                if (IsOpenedFormInPanel(form, panel)) //若form存在panel中，就替换
                    return;
                else
                {
                    form = openForm;
                    //panel.Controls.Clear();
                    //panel.Controls.Add(form);
                    //form.Show();
                    //return;
                }
            }
            panel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            form.Dock = DockStyle.Fill;
            panel.AutoScroll = true;
            panel.Controls.Add(form);
            form.Show();
        }



        /// <summary>
        /// DataGridView基本操作列的显示处理
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="isDeleted"></param>
        public static void ShowDgvCols(this DataGridView dgv, bool isDeleted)
        {
            dgv.Columns["colEdit"].Visible = !isDeleted;
            dgv.Columns["colDelete"].Visible = !isDeleted;
            dgv.Columns["colRecover"].Visible = isDeleted;
            dgv.Columns["colRemove"].Visible = isDeleted;
        }

        public static string GetDelName(int delCode)
        {
            string delName = "删除";
            switch (delCode)
            {
                case 1:
                    delName = "删除";
                    break;
                case 0:
                    delName = "恢复";
                    break;
                case 2:
                    delName = "移除";
                    break;
            }
            return delName;
        }



    }
}
