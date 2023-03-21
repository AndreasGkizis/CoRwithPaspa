using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chainofresponsibility2.Handlers;

namespace chainofresponsibility2
{
    //The abstract class will implement anything every chain will do.

    abstract class AbstractValidator<TSubject, TChain>
    {
        public TSubject Sub { get; set; }
        public TChain Type { get; set; }
        public List<IHandler<TSubject>> Handlers { get; private set; }
 
        public AbstractValidator(TSubject sub, TChain type)
        {
            Sub = sub;
            Type = type;

            // new(); finds the correct type of handlers and creates one 
            Handlers = new();
        }

         public abstract void Next();

    }
}
