﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Domain.Common
{
    public class BaseEntity<Tkey>
    {
        public Tkey Id { get;private set; }
        public DateTime CreateDate { get;private set; }
        public BaseEntity()
        {
            CreateDate = DateTime.Now;
        }
    }
}
