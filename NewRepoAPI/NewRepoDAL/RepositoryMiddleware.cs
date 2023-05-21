using INewRepoDAL;
using Microsoft.AspNetCore.Http;
using NewRepoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NewRepoDAL
{
    public class RepositoryMiddleware
    {
        private readonly RequestDelegate _next;

        public RepositoryMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, IRepository<User> userRepository)
        {
            // 使用userRepository进行操作，这里只是示例
            var users = await userRepository.GetAll();

            await _next(context);
        }
    }
}
