using PostModule.Domain.CityEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Domain.Services
{
    public interface IRepository<TKey ,T>
    {
       IEnumerable<T> GetAll();
       IEnumerable<T> GetAllBy(Expression<Func<T, bool>> expression);
       T GetById(TKey id);
       bool Create(T command);
        bool Delete(T command);
        bool ExistBy(Expression<Func<T, bool>> expression);
        bool Save();

    }
}
