
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using HTC.DAL.EF;
using HTCDOMAIN.Abstract;
using HTCSERVICES;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HTCUT
{
    [TestClass]
    public class DoesRepositoryWork
    {
        // CRUD

        ProductService service = new ProductService(new HtcEfDbContext());
        public Products product = new Products()
        {
            Id = 6,
            Name = "Pizza Karaibska",
            Price = (decimal)32.50
        };

        public Products product1 = new Products()
        {
            Name = "maczeta",
            Price = 69,

        };
        [TestMethod]
        public void CanAddProduct() //C
        {
            Products exepted = service.AddEntity(product);
            Assert.AreEqual(exepted.Name, "Pizza Karaibska");
            Assert.AreEqual(exepted.Price, (decimal)32.50);
            Assert.IsNotNull(product.Id);
        }

       

        [TestMethod]
        public void CanDeleteProduct()
        {
            try
            {
                bool isInDatabase;
                List<Products> lista = service.GetAll().ToList();
                var l = lista[0];
                service.DeleteEntity(lista[0]);
                List<Products> lista2 = service.GetAll().ToList();
                
                

                
            }
            catch (Exception ex)
            {

              Console.WriteLine(ex.ToString());
            }
            
            

            


        }

    }
}
