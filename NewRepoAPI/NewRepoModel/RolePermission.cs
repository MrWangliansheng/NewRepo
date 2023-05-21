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
    [Table("RolePermission")]
    public class RolePermission
    {
        /// <summary>
        /// 角色权限ID
        /// </summary>
        [Key]
        public int RP_Id { get; set; }
        /// <summary>
        /// 角色ID
        /// </summary>
        public int Role_Id { get;set; }
        /// <summary>
        /// 权限ID
        /// </summary>
        public int Permission_Id { get; set; }
    }
}
