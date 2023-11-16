using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTCS.DAL;

namespace WTCS.BLL
{
    public class UserBLL
    {
        UserDAL userDAL = new UserDAL();

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="uName">用户名</param>
        /// <param name="uPwd">用户密码</param>
        /// <returns>用户存在返回True，否则False</returns>
        public bool LoginSystem(string uName, string uPwd)
        {
            int userId = userDAL.LoginSystem(uName, uPwd);
            if (userId > 0)
                return true;
            else
                return false;
        }


    }
}
