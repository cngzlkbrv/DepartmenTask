﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentTask.Exceptions
{
    internal class CapacityLimitException:Exception
    {
        public CapacityLimitException(string message) : base(message)
        {

        }
    }
}
