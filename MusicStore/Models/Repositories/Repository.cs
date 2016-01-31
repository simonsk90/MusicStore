using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MusicStore.Models.Repositories
{
    public class Repository<T> where T : class
    {

        private MusicStoreDataContext context = null;

        protected DbSet<T> dbSet { get; set; }

        public Repository()
        {
            context = new MusicStoreDataContext();
            dbSet = context.Set<T>();
        }

        //public Repository(MusicStoreDataContext context)
        //{
        //    this.context = context;
        //}

        public List<T> getAll()
        {
            return dbSet.ToList();
        }

        public T get(int? id)
        {
            return dbSet.Find(id);
        }

        public void add(T entity)
        {
            dbSet.Add(entity);
        }

        public void saveChanges()
        {
            context.SaveChanges();
        }
    }
}