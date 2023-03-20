using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainofresponsibility2
{
    internal class WordSpaceWordChain : AbstractChain<Subject, ChainType>, IChain<Subject>
    {
        public WordSpaceWordChain(Subject sub, ChainType type)
            : base( sub, type)
        {
            IHandler<string> kati = new WordHandler<string>();
            switch (type)
            {
                case ChainType.WordSpaceWord:
                    Handlers.Add((IHandler<Subject>)kati);
                    break;
                case ChainType.StartsWithWhitespace:
                    break;

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
