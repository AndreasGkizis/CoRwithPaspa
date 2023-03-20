using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainofresponsibility2
{
    abstract class AbstractChain<T>
    {
        public List<IHandler<T>> Handlers { get ; private set ; }

        public AbstractChain(ChainType type)
        {
            // make a chain 
        }
      
    }
}
