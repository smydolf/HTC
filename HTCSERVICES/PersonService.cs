using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using HTC.DAL;
using HTC.DAL.EF;
using HTCDOMAIN.Abstract;
using HTCSERVICES.Interface;

namespace HTCSERVICES
{
    public class PersonService : Repository<Person>, IPersonService
    {
        public PersonService(HtcEfDbContext context) : base(context)
        {
        }

        public List<Person> GetAll()
        {
            return Context.Set<Person>().ToList();
        }

        public Person GetById(int id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return Context.Set<Person>().Find(id);
        }

        public void Update(Person person)
        {
            if (person == null)
            {
                throw new ArgumentNullException(nameof(person));
            }
            base.UpdateEntity(person);
        }

        public void Delete(Person person)
        {
            if (person == null)
            {
                throw new ArgumentNullException(nameof(person));
            }
            base.DeleteEntity(person);
        }

        public void DeleteById(int id)
        {
            var toDelete = GetById(id);
            if (toDelete == null)
            {
                throw new ArgumentNullException(nameof(toDelete));
            }
            Context.Set<Person>().Remove(toDelete);
        }

        public void AddNew(Person person)
        {
            if (person == null)
            {
                throw new ArgumentNullException(nameof(person));
            }
            base.AddEntity(person);
        }
    }
}
