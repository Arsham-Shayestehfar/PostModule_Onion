﻿using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PostModule.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Infrastructure.Repositories
{
    public class Repository<Tkey, T> : IRepository<Tkey, T> where T : class
    {
        readonly Post_Context _context;
        public Repository(Post_Context post_Context)
        {
            _context = post_Context;
        }
        public bool Create(T Entity)
        {
             _context.Add<T>(Entity);
            return Save();
        }

        public bool Delete(T Entity)
        {
            _context.Remove<T>(Entity);
            return Save();
        }

        public bool ExistBy(Expression<Func<T, bool>> expression) =>
            _context.Set<T>().Any(expression);



        public IEnumerable<T> GetAll() =>
            _context.Set<T>().ToList();


        public IEnumerable<T> GetAllBy(Expression<Func<T, bool>> expression) =>
            _context.Set<T>().Where(expression).ToList();

        public IQueryable<T> GetAllByQuery(Expression<Func<T, bool>> expression) =>
            _context.Set<T>().Where(expression);

        public IQueryable<T> GetAllQuery() =>
            _context.Set<T>();


        public T GetById(Tkey id) =>
        
            _context.Find<T>(id);
        

        public bool Save() =>
            _context.SaveChanges() >= 0 ?true:false;
       
    }
}
