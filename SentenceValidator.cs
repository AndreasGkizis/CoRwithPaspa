using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainofresponsibility2
{
    internal class SentenceValidator<T> : 
        AbstractChain<T, ChainType>, IChain<T>
    {
        public SentenceValidator(T sub, ChainType type)
            : base( sub, type)
        {
            IHandler<T> WordHandler1 = new WordHandler<T>();
            IHandler<T> WhiteSpaceHander1 = new WhitespaceHandler<T>();
            //IHandler<T> WordHandler2 = new WordHandler<T>();

            switch (type)
            {
                case ChainType.WordSpaceWord:
                    Handlers.Add(WordHandler1);
                    Handlers.Add(WhiteSpaceHander1);
                    Handlers.Add(WordHandler1);

                    
                    break;
                case ChainType.StartsWithWhitespace:
                    break;
            }
        }
        public bool Validate()
        {
            foreach (var handler in Handlers)
            {
                if (handler.Handle())
            }
        }
        public void Next()
        {
            //var part = sub.Parts.First();
            //Word.Handle(part);
            //part = sub.Parts[1];
            //Whitespace.Handle(part);
            //part = sub.Parts.Last();
            //Word.Handle(part);
            throw new NotImplementedException();
        }
    }
}
