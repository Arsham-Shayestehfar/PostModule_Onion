using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Application.Contract.CityApplication
{
    public interface ICityApplication
    {
        bool Create(CreateCityModel command);
        bool Create(EditCityModel command);
        bool ExistTitleForCreate(string title);
        bool ExistTitleForEdit(string title,int id );
        EditCityModel GetCityForEdit(int id);
        List<CityViewModel> GetAllForState(int stateId);
    }
}
