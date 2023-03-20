using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainofresponsibility2
{
    internal class WordHandler : IHandler<Subject>
    {
        public void Handle(Subject request)
        {

            //throw new NotImplementedException();
        }
    }
}
