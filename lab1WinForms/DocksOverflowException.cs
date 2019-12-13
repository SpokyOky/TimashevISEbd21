using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1WinForms
{
    class DocksOverflowException : Exception
    {
        public DocksOverflowException() :
            base("В доках нет свободных мест") { }
    }
}
