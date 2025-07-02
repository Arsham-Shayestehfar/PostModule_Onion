using PostModule.Domain.CityEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Domain.Services
{
    public interface IRepository<TKey ,T> where T :class
    {
       IEnumerable<T> GetAll();
       IEnumerable<T> GetAllBy(Expression<Func<T, bool>> expression);
       T GetById(TKey id);
       bool Create(T Entity);
        bool Delete(T Entity);
        bool ExistBy(Expression<Func<T, bool>> expression);
        bool Save();

    }
}
