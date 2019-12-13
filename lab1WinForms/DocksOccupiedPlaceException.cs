using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1WinForms
{
    class DocksOccupiedPlaceException : Exception
    {
        public DocksOccupiedPlaceException(int i) : 
            base("На месте " + i + "уже стоит корабль") { }
    }
}
