using System;
using System.Linq;
using System.Data.Entity;
using ClanScape.Data.Access.Context;
using ClanScape.Web.Api.Common.Interfaces.Repositories;

namespace ClanScape.Web.Api.Common.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public Repository(ClanScapeContext context)
        {
            Context = context;
            Context.Configuration.LazyLoadingEnabled = false;
            Context.Configuration.ProxyCreationEnabled = false;
        }

        protected ClanScapeContext Context { get; private set; }

        public IQueryable<T> All()
        {
            return Context.Set<T>();
        }

        public bool Delete(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            T item = Context.Set<T>().Find(id);

            if (item == null) throw new NullReferenceException($"No matching {typeof(T).Name} record found.");

            Context.Entry(item).State = EntityState.Deleted;

            return SaveChanges() > 0;
        }

        public T GetById(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            return Context.Set<T>().Find(id);
        }

        public bool Add(T item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));

            Context.Set<T>().Add(item);

            return SaveChanges() > 0;
        }

        private int SaveChanges()
        {
            return Context.SaveChanges();
        }
    }
}
