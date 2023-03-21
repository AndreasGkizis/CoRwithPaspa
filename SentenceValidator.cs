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
                case ChainType.Custom:

                    break;
            }
        }
        public bool Validate(List<IHandler<Subject>> customList)
        {
            foreach (var item in customList)
            {
                Next(item);
            }

            foreach (var item in Handlers)
            {
                if (!item.Handle())
                {
                    return false;
                }
                return true;
            }


        }
        public bool Validate()
        {
            foreach (var handler in Handlers)
            {
                //Next(handler);
                //if (!handler.Handle())
                //{
                //    // okay to add position to interface just in order to debug/log?
                //    Console.WriteLine("this {0} Handled false", handler.Subject);
                //    continue;
                //}
            }

            Console.WriteLine("SentenceValidator. This means everything evaluated true");
            return true;

        }
        public override void Next(IHandler<Subject> handler)
        {
            Handlers.Add(handler);

            // if the handle method is true then use next handler  
            // if false 

            //var part = sub.Parts.First();
            //Word.Handle(part);
            //part = sub.Parts[1];
            //Whitespace.Handle(part);
            //part = sub.Parts.Last();
            //Word.Handle(part);
            int kati = Handlers.IndexOf(Handlers[0]);
            throw new NotImplementedException();
        }
    }
}
