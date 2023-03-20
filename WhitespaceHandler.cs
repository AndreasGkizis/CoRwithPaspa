using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainofresponsibility2
{
    internal class WhitespaceHandler : IHandler<string>
    {
        /// <summary>
        /// Retuns true only if all of the chars in the part are whitespaces
        /// and less than 3
        /// </summary>
        /// <param name="part"></param>
        /// <returns></returns>
        public bool Handle(string part)=> (
            part.Length<=3 && 
            part.All(x=>x.Equals(" "))
        );
     
    }
}

