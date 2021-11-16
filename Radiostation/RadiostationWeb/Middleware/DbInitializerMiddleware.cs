using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using RadiostationWeb.Data;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RadiostationWeb.Middleware
{
    public class DbInitializerMiddleware
    {
        private readonly RequestDelegate _next;
        public DbInitializerMiddleware(RequestDelegate next)
        {
            _next = next;

        }
        public async Task Invoke(HttpContext context, BDLab1Context dbContext, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (!(context.Session.Keys.Contains("isDbInitialized")))
            {
                DbInitializer.InitializeDb(dbContext);
                await DbInitializer.InitializeIdentity(userManager, roleManager);
                context.Session.SetString("isDbInitialized", "Yes");
            }

            await _next.Invoke(context);
        }
    }
    public static class DbInitializerExtensions
    {
        public static IApplicationBuilder UseDbInitializer(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<DbInitializerMiddleware>();
        }
    }
}
