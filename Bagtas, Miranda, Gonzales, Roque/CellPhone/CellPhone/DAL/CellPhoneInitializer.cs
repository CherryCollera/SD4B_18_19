using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CellPhone.Models;

namespace CellPhone.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CellPhoneContext>
    {
        protected override void Seed(CellPhoneContext context)
        {
            var brands = new List<Brand>
            {
            new Brand{BrandName="Carson",Model="Alexander"},
            new Brand{BrandName="Meredith",Model="Alonso"},
            new Brand{BrandName="Arturo",Model="Anand"},
            new Brand{BrandName="Gytis",Model="Barzdukas"}
            };

            brands.ForEach(s => context.Brands.Add(s));
            context.SaveChanges();
            
        }
    }
}