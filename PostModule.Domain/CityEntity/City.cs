using _Utitlities.Enums;
using PostModule.Domain.Common;

using PostModule.Domain.StateEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Domain.CityEntity
{
    public class City:BaseEntity<int>
    {
        public int StateId { get; set; }
        public string Title { get; set; }
       
        public CityStatus Status { get; set; }
        public State State { get; set; }

        public City(string title,int stateId,CityStatus status)
        {
            StateId = stateId;
            Title = title;
           Status = status;
            
            
        }
        public void Edit(string title, CityStatus status)
        {
            Title = title;
            Status = status;
        }
        public void IsTehran()
        {
           Status = CityStatus.تهران;
        }
        public void IsCenter()
        {
           Status = CityStatus.مرکز_استان;
        }
        public void NotCenterOrTehran()
        {
            Status = CityStatus.شهرستان_معمولی;
        }
    }
}
