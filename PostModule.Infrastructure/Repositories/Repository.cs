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
        public bool Create(T command)
        {
            throw new NotImplementedException();
        }

        public bool Delete(T command)
        {
            throw new NotImplementedException();
        }

        public bool ExistBy(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAllBy(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public T GetById(Tkey id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }
    }
}
