using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime;

namespace NewRepoModel
{
    [Table("User")]
    public class User
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [Key]
        public int User_Id { get; set; }
        /// <summary>
        /// 用户名称
        /// </summary>
        public string? User_Name { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string? User_Password { get; set; }
        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string? User_Email { get; set; }
        /// <summary>
        /// 注册日期
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public bool User_IsDelete { get; set; }
    }
}