using System;
using System.Linq;
using System.Linq.Expressions;
using HTCDOMAIN.Abstract;

namespace HTCSERVICES.Interface
{
    public interface IPersonService
    {
        IQueryable<Person> GetList();
        Person AddEntity(Person person);
        Person UpdateEntity(Person person);
        void DeleteEntity(Person person);
        IQueryable<Person> GetList(Expression<Func<Person, bool>> query);
        Person GetEntity<T>(object primaryKey);
    }
}
