using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using GMF.Component.Tools;


namespace GMF.Demo.Core.Models.Account
{
    /// <summary>
    /// 实体类——登录记录信息
    /// </summary>
    [Description("登录记录信息")]
    public class LoginLog : EntityBase<Guid>
    {
        /// <summary>
        /// 初始化一个 登录记录实体类 的新实例
        /// </summary>
        public LoginLog()
        {
            Id = CombHelper.NewComb();
        }

        [Required]
        [StringLength(15)]
        public string IpAddress { get; set; }

        /// <summary>
        /// 获取或设置 所属用户信息
        /// </summary>
        public virtual Member Member { get; set; }
    }
}
