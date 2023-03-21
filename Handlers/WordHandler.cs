using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainofresponsibility2.Handlers
{
    internal class WordHandler : IHandler<Subject> //IHandler<Subject>, IHandler<string>
    {
        public Subject Subject { get; set; }
        public int Position { get; set; }

        public WordHandler(Subject subject, int position)
        {
            Subject = subject;
            Position = position;
        }

        // returns true when the part is longer than 1 and does NOT contain spaces 
        public bool Handle() => 
            Subject.Parts[Position].Length >= 1 && 
            !Subject.Parts[Position].Contains(' ');
 

        /// <summary>
        /// returns true when the part is longer than 1 and does NOT contain spaces 
        /// </summary>
        /// <param name="part"></param>
        /// <returns></returns>

        //public bool Handle(string part)=> 
        //    (part.Length >= 1 && !part.Contains(" "));
    }
}
