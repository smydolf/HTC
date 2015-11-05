using System;
using System.Text;
using HTC.DAL;
using HTC.DAL.EF;
using HTC.DAL.Interface;
using HTCDOMAIN.Abstract;
using HTCSERVICES;
using HTCSERVICES.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace HTCUT
{
    //[TestClass]
    //public class UnitTest2
    //{
    //    [TestMethod]
    //    public void CanAddProduct()
    //    {

    //        var Name = "Pizza Karaibska";
    //        var product = new Products();
    //        product.Name = Name;


    //        HtcEfDbContext orm = new HtcEfDbContext();
    //        IUnitOfWork utOfWork = new UnitOfWorks(orm);
    //        IRepository repo = new ProductService(utOfWork);

    //        var expepted = repo.AddEntity(product);
    //        Assert.AreEqual(expepted.Name, "Piza Karaibska");
    //    }
    //}
}
