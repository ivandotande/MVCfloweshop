using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCFlowerShopLab2.Models;

namespace MVCFlowerShopLab2.Data
{
    public class MVCFlowerShopLab2Context : DbContext
    {
        public MVCFlowerShopLab2Context (DbContextOptions<MVCFlowerShopLab2Context> options)
            : base(options)
        {
        }

        public DbSet<MVCFlowerShopLab2.Models.Flower> Flower { get; set; }
    }
}
