using System;
using Hello.Areas.Identity.Data;
using Hello.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Hello.Areas.Identity.IdentityHostingStartup))]
namespace Hello.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<HelloContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("HelloContextConnection")));

                services.AddDefaultIdentity<HelloUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<HelloContext>();
            });
        }
    }
}