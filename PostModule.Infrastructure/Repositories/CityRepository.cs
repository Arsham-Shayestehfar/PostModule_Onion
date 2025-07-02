using Microsoft.EntityFrameworkCore;
using PostModule.Domain.CityEntity;
using PostModule.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Infrastructure.Repositories
{
    public class CityRepository : Repository<int, City>, ICityRepository
    {
        public CityRepository(DbContext post_Context) : base(post_Context)
        {
        }
    }
}
