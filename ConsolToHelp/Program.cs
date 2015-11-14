using System;
using HTC.DAL.EF;
using HTCDOMAIN.Abstract;
using HTCDOMAIN.AbstractDB;
using HTCSERVICES;
using HTCSERVICES.NewServices;

namespace ConsolToHelp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductDbObject product1 = new ProductDbObject()
            {
                Category = new CategoryDbObject()
                {
                    Name = "Pizza",
                    PrimaryKey = new Guid()
                },
                Name = "JakasTam",
                PrimaryKey = new Guid()
            };

            CategoryDbObject PizzaCategory = new CategoryDbObject()
            {
                Name = "Pizza",
                PrimaryKey = new Guid()
            };

            
            CategoryService catgeService = new CategoryService(new HtcEfDbContext());
            catgeService.AddEntity(PizzaCategory);
            catgeService.SaveChange();

        }
    }
}
