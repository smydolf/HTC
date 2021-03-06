﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using HTCDOMAIN.Abstract;

namespace HTC.DAL.Interface
{
    public interface IRepository<T> where T:  class
    {
        IEnumerable<T> QEntityQueryable { get; } 
         T AddEntity(T entity);
        void UpdateEntity(T entity);

        T DeleteEntity(T entity);

        IEnumerable<T> GetList();

        IQueryable<T> GetList(Expression<Func<T, bool>> query);

        T GetEntity(object primarykey);
    }
}
