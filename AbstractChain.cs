using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainofresponsibility2
{
    //The abstract class will implement anything every chain will do.

    abstract class AbstractChain<TSubject, TChain>
    {
        public TSubject Sub { get; set; }
        public TChain Type { get; set; }
        public List<IHandler<TSubject>> Handlers { get; private set; }
        //public WordHandler Word { get; set; }
        //public WhitespaceHandler Whitespace { get; set; }

        //public AbstractChain()
        //{
        //    Handlers.Add(new WordHandler());
        //    Handlers.Add(new WhitespaceHandler());
        //}
        public AbstractChain(TSubject sub, TChain type)
        {
            Sub = sub;
            Type = type;

            // new(); finds the correct type of handlers and creates one 
            Handlers = new();
            // make a chain, use the type to make diferent chains
        }

    }
}
