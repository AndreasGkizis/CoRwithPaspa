using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainofresponsibility2
{
    internal interface IValidator
    {
        public bool Validate();
    }
}
