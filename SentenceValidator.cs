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
        public SentenceValidator(T sub, ChainType type, ValidationType valType)
            : base(sub, type)
        {
            switch (type)
            {
                case ChainType.WordSpaceWord:

                    Handlers.Add(new WordHandler<T>(sub, Handlers.Count));
                    Handlers.Add(new WhitespaceHandler<T>(sub, Handlers.Count));
                    Handlers.Add(new WordHandler<T>(sub, Handlers.Count));
                    if (valType == ValidationType.Auto) // Validate();
                    {
                        Validate();
                    }
                    break;
                case ChainType.StartsWithWhitespace:
                    Handlers.Add(new WhitespaceHandler<T>(sub, Handlers.Count));
                    Handlers.Add(new WordHandler<T>(sub, Handlers.Count));
                    if (valType == ValidationType.Auto) // Validate();
                    {
                        Validate();
                    }

                    break;
            }
        }
        public bool Validate()
        {
            int i = 0;
            foreach (var handler in Handlers)
            {
                if (handler.Handle() == true)
                {

                }
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
