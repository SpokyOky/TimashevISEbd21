using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1WinForms
{
    class DocksNotFoundException : Exception
    {
        public DocksNotFoundException(int i) : 
            base("Не найден корабль по месту " + (i + 1)) { }
    }
}
