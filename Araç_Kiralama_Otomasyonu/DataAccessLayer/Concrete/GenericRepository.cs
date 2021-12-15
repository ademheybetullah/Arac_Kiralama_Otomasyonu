﻿using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context context = new Context();
        DbSet<T> _object;
        public GenericRepository()
        {
            _object = context.Set<T>();
        }
        public void Delete(T entity)
        {
            _object.Remove(entity);
            context.SaveChanges();
        }

        public void Insert(T entity)
        {
            _object.Add(entity);
            context.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public void Update(T entity)
        {
            context.SaveChanges();
        }
    }
}
