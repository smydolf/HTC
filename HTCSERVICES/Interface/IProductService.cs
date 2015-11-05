using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using HTCDOMAIN.Abstract;

namespace HTCSERVICES.Interface
{
    public interface IProductService
    {
        List<Products> GetAll();
        Products GetById(int id);
        void Update(Products products);
        void Delete(Products products);
        void DeleteById(int id);
        void AddNew(Products products);
    }
}
