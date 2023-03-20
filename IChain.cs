using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainofresponsibility2
{
    internal interface IChain<T>
    {
        public List<IHandler<T>> Handlers { get; }
        //IHandler<T> MakeChain(List<IHandler<T>> Handlers);
        void Next();
    }
}
