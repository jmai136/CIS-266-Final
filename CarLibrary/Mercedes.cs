﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Mercedes<T> : Car
    {
       public T engine { get; set; }
    }
}
