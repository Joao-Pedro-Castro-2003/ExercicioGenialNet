using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenialNet.Exceptions
{
    internal class Consistencias : ApplicationException
    {
        public Consistencias()
        {
        }
        public Consistencias(string message)
        : base(message)
        {
        }
    }
}
