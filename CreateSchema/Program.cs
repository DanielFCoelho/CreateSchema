using Domain;
using Microsoft.EntityFrameworkCore;
using Repository;
using System;
using System.Linq;
using System.Reflection;

namespace CreateSchema
{
    class Program
    {
        static void Main(string[] args)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes()
            .Where(t => t.IsClass)
            .ToList();


            var urlBase = AppContext.BaseDirectory;

            var ass = Assembly.LoadFile($@"{urlBase}Domain.dll");

            var lst = ass.GetTypes().Where(p => p.Namespace == "Domain" &&  p.IsClass).ToList();

            foreach (var item in lst)
            {
                foreach (var prop in item.GetProperties())
                {
                    using (var ctx = new Context())
                    {
                        ctx.Database.ExecuteSqlCommand(@$"ALTER TABLE PRODUTO ADD COLUMN {} varchar(20)")
                    }
                }
            }
            

            //AssemblyName assemblyName = new AssemblyName("Domain.dll");
            //var q = Assembly.Load(assemblyName);
            //var classes = q
            //    .GetTypes()
            //    .Where(p => p.Namespace == "Domain" && p.Name.Contains("Produto"))
            //    .ToList();


        }

        //static GetTableName(string className)
        //{
        //    switch (className)
        //    {
        //        case "Produto"
        //        default:
        //            break;
        //    }
        //}

    }
}
