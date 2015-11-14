using System.Collections.Generic;
using System.Linq;
using HTC.DAL.Interface;
using HTCDOMAIN.Abstract;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace HTCUT
{
    /// <summary>
    /// We want to test CRUD
    /// C - Create
    /// R - Read
    /// U - Update
    /// D - Delete
    /// 
    /// What i have done ?
    /// I created a fake repository (the same as our repository) this is list of products.
    /// After that i created new MOQ object typeof Irepository.
    /// And I imitaed behaviour our method ;) 
    /// </summary>
    [TestClass]
    public class DoesRepositoryWork
    {

        private IRepository<Products> repository = null;

        private Products prod1 = new Products()
        {
            Id = 4,
            Name = "Rapid salad",
            Price = (decimal)10.0
        };

        public DoesRepositoryWork()
        {
            List<Products> products = new List<Products>()
        {
            new Products
            {
                Id = 1,
                Name = "Margaritha",
                Price = (decimal) 10.0
            },

            new Products
            {
                Id = 2,
                Name = "Fuji",
                Price = (decimal) 20.0
            },

            new Products
            {
                Id = 3,
                Name = "User",
                Price = (decimal) 30.0
            },
        };
            Mock<IRepository<Products>> mockRepo = new Mock<IRepository<Products>>();
            mockRepo.Setup(m => m.GetList()).Returns(products);
            mockRepo.Setup(m => m.GetEntity(It.IsAny<int>()))
                .Returns((int i) => products.Single(x => x.Id == i));

            mockRepo.Setup(m => m.AddEntity(It.IsAny<Products>())).Returns((Products product) =>
            {
                products.Add(product);
                return product;
            });
            mockRepo.Setup(m => m.DeleteEntity(It.IsAny<Products>())).Returns((Products product) =>
            {
                products.Remove(product);
                return product;
            });
            this.repository = mockRepo.Object;
        }

        [TestMethod]
        public void CanReturnAllProduct()
        {
            int productCount = this.repository.GetList().Count();
            Assert.AreEqual(3, productCount);
        }

        [TestMethod]
        public void CanReturnProductById()
        {
            Products testProduct = this.repository.GetEntity(1);
            Assert.IsNotNull(testProduct);
            Assert.AreEqual("Margaritha", testProduct.Name);
        }

        [TestMethod]
        public void CanAddNewItem()
        {
            int productCount = this.repository.GetList().Count();
            Assert.AreEqual(3, productCount);
            this.repository.AddEntity(prod1);

            productCount = this.repository.GetList().Count();
            Assert.AreEqual(4, productCount);
        }

        [TestMethod]
        public void CanRemoveItem()
        {
            int productCount = this.repository.GetList().Count();
            Assert.AreEqual(3, productCount);
            this.repository.AddEntity(prod1);

            productCount = this.repository.GetList().Count();
            Assert.AreEqual(4, productCount);

            this.repository.DeleteEntity(prod1);

            productCount = this.repository.GetList().Count();
            Assert.AreEqual(3, productCount);
        }
    }
}




