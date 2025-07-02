using PostModule.Application.Contract.StateApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostModeule.Application.Services
{
    public class StateApplication : IStateApplication
    {
        public bool Creat(CreateStateModel command)
        {
            throw new NotImplementedException();
        }

        public bool Edit(EditStateModel command)
        {
            throw new NotImplementedException();
        }

        public List<StateViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public EditStateModel GetStateForEdit(int id)
        {
            throw new NotImplementedException();
        }

        public bool IsTitleExistForCrreate(string title)
        {
            throw new NotImplementedException();
        }

        public bool IsTitleExistForEdit(string title, int id)
        {
            throw new NotImplementedException();
        }
    }
}
