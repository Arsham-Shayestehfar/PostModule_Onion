using Microsoft.EntityFrameworkCore;
using PostModule.Application.Contract.CityApplication;
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
        public CityRepository(Post_Context post_Context) : base(post_Context)
        {
        }

        public List<CityViewModel> GetAllForState(int stateId)
        {
            return GetAllByQuery(c=>c.StateId == stateId).Select(c=> new CityViewModel
            {
                CreateDate = c.CreateDate.ToString(),
                Title = c.Title,
                Id = c.Id,
                Status = c.Status,

            }).ToList();
        }

        public EditCityModel GetCityForEdit(int id)
        {
            var city = GetById(id);
            return new()
            {
                Id = city.Id,
                Status = city.Status,
                Title = city.Title,
            };
        }
    }
}
