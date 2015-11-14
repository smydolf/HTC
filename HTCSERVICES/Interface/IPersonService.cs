using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using HTCDOMAIN.Abstract;

namespace HTCSERVICES.Interface
{
    public interface IPersonService
    {
        List<Person> GetAll();
        Person GetById(int id);
        void Update(Person person);
        void Delete(Person person);
        void DeleteById(int id);
        void AddNew(Person person);
    }
}
