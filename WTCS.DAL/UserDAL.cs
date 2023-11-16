using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTCS.DAL.Base;
using WTCS.Models.DModels;

namespace WTCS.DAL
{
    public class UserDAL : BaseDAL<UserInfoModel>
    {


        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="uName">用户名</param>
        /// <param name="uPwd">密码</param>
        /// <returns></returns>
        public int LoginSystem(string uName, string uPwd)
        {
            string strWhere = "UserName=@userName and UserPwd=@userPwd and UserState=1 and IsDeleted=0";
            SqlParameter[] parameters =
            {
                new SqlParameter("@userName",uName),
                new SqlParameter("@userPwd",uPwd)
            };

            UserInfoModel user = GetModel(strWhere, "UserId", parameters);

            if (user == null)
                return 0;
            else
                return user.UserId;
        }
    }
}
