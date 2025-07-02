using PostModule.Application.Contract.CityApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostModeule.Application.Services
{
    public class CityApplication : ICityApplication
    {
        public bool Create(CreateCityModel command)
        {
            throw new NotImplementedException();
        }

        public bool Create(EditCityModel command)
        {
            throw new NotImplementedException();
        }

        public bool ExistTitleForCreate(string title)
        {
            throw new NotImplementedException();
        }

        public bool ExistTitleForEdit(string title, int id)
        {
            throw new NotImplementedException();
        }

        public List<CityViewModel> GetAllForState(int stateId)
        {
            throw new NotImplementedException();
        }

        public EditCityModel GetCityForEdit(int id)
        {
            throw new NotImplementedException();
        }
    }
}
