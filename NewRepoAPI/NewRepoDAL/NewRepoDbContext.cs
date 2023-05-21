using Microsoft.EntityFrameworkCore;
using NewRepoModel;

namespace NewRepoDAL
{
    public class NewRepoDbContext: DbContext
    {
        public NewRepoDbContext(DbContextOptions<NewRepoDbContext> options) : base(options) { }
        /// <summary>
        /// 用户
        /// </summary>
        public DbSet<User> User { get; set; }
        /// <summary>
        /// 角色
        /// </summary>
        public DbSet<Role> Role { get; set; }
        /// <summary>
        /// 用户角色中间表
        /// </summary>
        public DbSet<UserRole> UserRole { get; set; }
        /// <summary>
        /// 权限
        /// </summary>
        public DbSet<Permission> Permission { get; set; }
        /// <summary>
        /// 角色权限中间表
        /// </summary>
        public DbSet<RolePermission> RolePermission { get; set; }
    }
}