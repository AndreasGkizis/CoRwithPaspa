using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chainofresponsibility2.Handlers;
using chainofresponsibility2.Models;

namespace chainofresponsibility2
{
    internal class SentenceValidator :
        AbstractValidator<Subject, ChainType>, IValidator
    {
        public SentenceValidator(Subject sub, ChainType type, ValidationType valType)
            : base(sub, type)
        {
            switch (type)
            {
                case ChainType.WordSpaceWord:

                    Handlers.Add(new WordHandler(sub, Handlers.Count));
                    Handlers.Add(new WhitespaceHandler(sub, Handlers.Count));
                    Handlers.Add(new WordHandler(sub, Handlers.Count));
                    if (valType == ValidationType.Auto) // Validate();
                    {
                        Validate();
                    }
                    break;
                case ChainType.StartsWithWhitespace:
                    Handlers.Add(new WhitespaceHandler(sub, Handlers.Count));
                    Handlers.Add(new WordHandler(sub, Handlers.Count));
                    if (valType == ValidationType.Auto) // Validate();
                    {
                        Validate();
                    }

                    break;
            }
        }
        public bool Validate()
        {

            foreach (var handler in Handlers)
            {
                if (!handler.Handle())
                {
                    Console.WriteLine("this Handled false", handler.Subject);
                    return false;
                }
            }
            //Console.WriteLine(Handlers[0].Handle());
            //Console.WriteLine(Handlers[1].Handle());
            //Console.WriteLine(Handlers[2].Handle());
            Console.WriteLine("SentenceValidator .This means everything rvaluated true all seems right");

            return true;

        }
        public override void Next()
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
