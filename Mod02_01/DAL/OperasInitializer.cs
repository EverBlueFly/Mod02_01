using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mod02_01.Models;
using System.Data.Entity;

namespace Mod02_01.DAL 
{
    public class OperasInitializer : DropCreateDatabaseAlways<OperaContext>
    {
        protected override void Seed(OperaContext context)
        {
            base.Seed(context);
            Opera op = new Opera();
            op.OperaId = 2;
            op.Title = "1";
            op.Year = 1921;
            op.Composer = "moz1";
            context.Operas.Add(op);
            //context.Operas.Add(new Opera()
            //{
            //    Title = "Cosi Fan Tutte",
            //    Year = 1790,
            //    Composer = "Mozart"
            //});
            context.SaveChanges();
        }
    }
}