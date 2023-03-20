using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainofresponsibility2
{
    internal class WordHandler<T> : IHandler<string>
    {
        /// <summary>
        /// returns true when the part is longer than 1 and does NOT contain spaces 
        /// </summary>
        /// <param name="part"></param>
        /// <returns></returns>
        public bool Handle(string part)=> (part.Length >= 1 && !part.Contains(" "));
       
    }
}
