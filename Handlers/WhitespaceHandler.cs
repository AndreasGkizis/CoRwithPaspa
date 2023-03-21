using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainofresponsibility2.Handlers
{
    internal class WhitespaceHandler : IHandler<Subject> //IHandler<Subject>, IHandler<string>
    {
        public Subject Subject { get; set; }
        public int Position { get; set; }
        public WhitespaceHandler(Subject subject, int position)
        {
            Subject = subject;
            Position = position;
        }

        // Retuns true only if all of the chars in the part are whitespaces
        public bool Handle() => (
            Subject.Parts[Position].Length <= 3 &&
            Subject.Parts[Position].All(x => x.Equals(' ')));
    }
}


