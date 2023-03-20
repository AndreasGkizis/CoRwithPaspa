using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainofresponsibility2
{
    internal interface IHandler<T>
    {
        bool Handle(T part);

        // we will implement a way so that the
        // next will not be in every handler
        //void Next();
    }
}
