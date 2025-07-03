using PostModule.Application.Contract.CityApplication;
using PostModule.Domain.CityEntity;

using PostModule.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostModeule.Application.Services
{
    public class CityApplication : ICityApplication
    {
        readonly ICityRepository _city;
        public CityApplication(ICityRepository city)
        {
            _city = city;
        }
        public bool Create(CreateCityModel command)
        {
            City city = new(command.Title,command.StateId,command.Status); 
            return _city.Create(city);
        }

        public bool Edit(EditCityModel command)
        {
            var city = _city.GetById(command.Id);
            city.Edit(command.Title,command.Status);
            return _city.Save();
        }

        public bool ExistTitleForCreate(string title,int stateId) =>
        
            _city.ExistBy(c=>c.Title == title && c.StateId == stateId );
        

        public bool ExistTitleForEdit(string title, int id ,int stateId) =>
        
            _city.ExistBy(c => c.Title == title && c.Id ==id && c.StateId == stateId);
        

        public List<CityViewModel> GetAllForState(int stateId) =>
        
         _city.GetAllForState(stateId);
           
                
        

        public EditCityModel GetCityForEdit(int id) =>
            _city.GetCityForEdit(id);


    }
}
