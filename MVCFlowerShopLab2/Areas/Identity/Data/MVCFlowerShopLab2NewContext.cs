using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCFlowerShopLab2.Areas.Identity.Data;

namespace MVCFlowerShopLab2.Data
{
    public class MVCFlowerShopLab2NewContext : IdentityDbContext<MVCFlowerShopLab2User>
    {
        public MVCFlowerShopLab2NewContext(DbContextOptions<MVCFlowerShopLab2NewContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
