﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentTask.Abstraction
{
    internal interface IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string ShowInfo();
       
    }
}
