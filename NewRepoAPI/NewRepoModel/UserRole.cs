using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepoModel
{
    [Table("UserRole")]
    public class UserRole
    {
        /// <summary>
        /// 用户角色ID
        /// </summary>
        [Key]
        public int UR_Id { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public int User_Id { get; set; }
        /// <summary>
        /// 角色ID
        /// </summary>
        public int Role_Id { get; set; }
    }
}
