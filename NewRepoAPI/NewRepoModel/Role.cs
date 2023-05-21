using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepoModel
{
    [Table("Role")]
    public class Role
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        [Key]
        public int Role_Id { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string? Role_Name { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public bool Role_IsDelete { get; set; }
    }
}
