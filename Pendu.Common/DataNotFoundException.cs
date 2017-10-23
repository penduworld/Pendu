﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendu.Common
{
    class DataNotFoundException: Exception

    {
        public DataNotFoundException(string message) : base(message)
        {

        }

        public DataNotFoundException(string message, Exception innerException): base(message, innerException)
        {

        }
    }
}
