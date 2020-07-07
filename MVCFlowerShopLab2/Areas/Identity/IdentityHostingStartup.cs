using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MVCFlowerShopLab2.Areas.Identity.Data;
using MVCFlowerShopLab2.Data;

[assembly: HostingStartup(typeof(MVCFlowerShopLab2.Areas.Identity.IdentityHostingStartup))]
namespace MVCFlowerShopLab2.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MVCFlowerShopLab2NewContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MVCFlowerShopLab2NewContextConnection")));

                services.AddDefaultIdentity<MVCFlowerShopLab2User>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<MVCFlowerShopLab2NewContext>();
            });
        }
    }
}