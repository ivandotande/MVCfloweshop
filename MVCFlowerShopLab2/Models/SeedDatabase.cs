using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCFlowerShopLab2.Data;

namespace MVCFlowerShopLab2.Models
{
    public class SeedDatabase
    {
        public static void Intialize(IServiceProvider serviceProvider)
        {
            //which db to linked to in this method
            using (var context = new MVCFlowerShopLab2Context(
                serviceProvider.GetRequiredService<DbContextOptions<MVCFlowerShopLab2Context>>()
                ))
            {
                //seach flower table and check whether it is still empty or not
                //emoty = new table; not empty= existing data alrdy there
                if (context.Flower.Any())
                {
                    return;
                }
                //if not data then we will add on the data.
                context.Flower.AddRange(
                    new Flower
                    {
                        FlowerName = "Chysanthenum",
                        Type = "Aesthethic",
                        FlowerProducedDate = DateTime.Parse("2018-2-12")    ,
                        Price = 5000M,
                        Rating = "3.5",
                    },
                    new Flower
                    {
                        FlowerName = "Angrek",
                        Type = "Belanda",
                        FlowerProducedDate = DateTime.Parse("2020-6-12"),
                        Price = 1500M,
                        Rating = "4.5",
                    }
                 );
                context.SaveChanges(); //save final changes , w/o this, there will be no change
            }
        }
    }
}
