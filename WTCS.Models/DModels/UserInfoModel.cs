using Common.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTCS.Models.DModels
{
    /// <summary>
    /// 用户信息实体
    /// </summary>
    /// 

    [Table("UserInfos")]
    [PrimaryKey("UserId", autoIncrement = true)]
    public class UserInfoModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPwd { get; set; }
        public int UserState { get; set; }
        public int IsDeleted { get; set; }
    }
}
