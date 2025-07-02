using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Application.Contract.StateApplication
{
    public interface IStateApplication
    {
        bool Creat(CreateStateModel command);
        bool Edit(EditStateModel command);
        List<StateViewModel> GetAll();
        EditStateModel GetStateForEdit(int id);
        bool IsTitleExistForCrreate (string title);
        bool IsTitleExistForEdit(string title,int id );
    }
}
