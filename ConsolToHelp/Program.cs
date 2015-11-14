﻿using System;
using HTC.DAL.EF;
using HTCDOMAIN.Abstract;
using HTCSERVICES;

namespace ConsolToHelp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Products product1 = new Products()
            {
                Name = "maczeta",
                Price = 69,

            };
            //Driver driver = new Driver()
            //{
            //    FirstName = "Adrian",
            //    LastName = "Smyda",
            //};
            Driver driver = new Driver()
            {
                Id = 0,
                AddedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                FirstName = "Adrian",
                LastName = "Smyda"

            };

            HtcEfDbContext context = new HtcEfDbContext();
            ProductService service = new ProductService(context);
            DriverService service2 = new DriverService(context);
            service.AddEntity(product1);
            service2.AddEntity(driver);

            service.SaveChange();
            service2.SaveChange();

            //pobieranie

            var lista = service.GetAll();
            foreach (var l in lista)
            {
                Console.WriteLine(l.Name + "   "+l.Price);
            }

           

            //usuwanie
            
            service2.DeleteEntity(driver);
            service2.SaveChange();
            Console.WriteLine("-----------");
            var lista2 = service.GetAll();
            foreach (var l in lista2)
            {
                Console.WriteLine(l.Name + "   " + l.Price);
            }

            Console.ReadKey();
        }
    }
}
