using Microsoft.EntityFrameworkCore;
using PostModule.Application.Contract.StateApplication;
using PostModule.Domain.Services;
using PostModule.Domain.StateEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Infrastructure.Repositories
{
    public class StateRepository : Repository<int, State>, IStateRepository
    {
        public StateRepository(Post_Context post_Context) : base(post_Context)
        {
        }

        public List<StateViewModel> GetAllStateViewModel()
        {
           return GetAllQuery().Select(s=> new StateViewModel
           {
               Id = s.Id,
               Title = s.Title,
               

           }).ToList();
        }

        public EditStateModel GetStateForEdit(int id)
        {
           var state  = GetById(id);
            return new()
            {
                Id = state.Id,
                Title = state.Title,
            };
        }
    }
}
