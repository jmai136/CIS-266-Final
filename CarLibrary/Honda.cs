using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Honda<T> : Car
    {
        public T mileage { get; set; }
    }
}
