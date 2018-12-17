using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CellPhone.Models;

namespace CellPhone.DAL
{
    public class CellPhoneInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CellPhoneContext>
    {
        protected override void Seed(CellPhoneContext context)
        {
            var brands = new List<Brand>
            {
            new Brand{BrandName="Samsung",Model="A7" },
            new Brand{BrandName="Cherry",Model="Flare4" },
            new Brand{BrandName="Asus",Model="ZenPhone C" },

            };

            brands.ForEach(s => context.Brands.Add(s));
            context.SaveChanges();
        }

    }
}
