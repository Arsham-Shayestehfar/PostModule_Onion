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
        public bool Tehran { get; set; }
        public bool Center { get; set; }
        public State State { get; set; }

        public City(string title,int stateId)
        {
            StateId = stateId;
            Title = title;
            Tehran = false;
            Center = false;
            
            
        }
        public void Edit(string title)
        {
            Title = title;
        }
        public void IsTehran()
        {
            Tehran = true;
            Center=false;
        }
        public void IsCenter()
        {
            Tehran = false;
            Center = true;
        }
        public void NotCenterOrTehran()
        {
            Tehran = false;
            Center = false;
        }
    }
}
