﻿using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public string CustomerId { get; set; }
        public string  ContactNanme { get; set; }
        public string  CompanyName { get; set; }
        public string City { get; set; }
        

    }
}
