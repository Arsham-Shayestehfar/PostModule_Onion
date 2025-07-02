using PostModule.Application.Contract.StateApplication;
using PostModule.Domain.Services;
using PostModule.Domain.StateEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostModeule.Application.Services
{
    public class StateApplication : IStateApplication
    {
        readonly IStateRepository _state;
        public StateApplication(IStateRepository state)
        {
            _state = state;
        }
        public bool Create(CreateStateModel command)
        {
            State state = new State(command.Title);
            return _state.Create(state);
        }

        public bool Edit(EditStateModel command)
        {
            var state = _state.GetById(command.Id);
            state.Edit(command.Title);
            return _state.Save();

        }

        public List<StateViewModel> GetAll() =>
            _state.GetAll().Select(s=> new StateViewModel
            {
                Id = s.Id,
                Title = s.Title,
                
            }).ToList();
       

        public EditStateModel GetStateForEdit(int id) 
            {
             var state =  _state.GetById(id);
            return new EditStateModel()
            { 
                Id = id,
                Title = state.Title,
            };
            }
            
        

        public bool IsTitleExistForCreate(string title) =>
        
            _state.ExistBy(s => s.Title == title);
        

        public bool IsTitleExistForEdit(string title, int id) =>
            _state.ExistBy(s => s.Title == title && s.Id != id);

    }
}
