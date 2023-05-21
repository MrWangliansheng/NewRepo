using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepoModel
{
    [Table("Permission")]
    public class Permission
    {
        /// <summary>
        /// 权限ID
        /// </summary>
        [Key]
        public int Permission_Id { get; set; }
        /// <summary>
        /// 权限名称
        /// </summary>
        public string? Permission_Name { get; set; }
        /// <summary>
        /// 权限描述
        /// </summary>
        public string? Permission_Description { get; set; }
    }
}
