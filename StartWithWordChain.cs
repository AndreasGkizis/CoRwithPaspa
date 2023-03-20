using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainofresponsibility2
{
    internal class StartWithWordChain : AbstractChain<Subject>, IChain<Subject>
    {
        public StartWithWordChain(ChainType type) : base(type)
        {
        }

        public void Next()
        {
            throw new NotImplementedException();
        }
    }
}
