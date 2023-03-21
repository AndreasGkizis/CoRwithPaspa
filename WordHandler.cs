using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainofresponsibility2
{
    internal class WordHandler<T> : IHandler<T> //IHandler<Subject>, IHandler<string>
    {
        public T Subject { get; set; }
        public int Position { get; set; }
        /// <summary>
        /// returns true when the part is longer than 1 and does NOT contain spaces 
        /// </summary>
        /// <param name="part"></param>
        /// <returns></returns>

        //public bool Handle(string part)=> 
        //    (part.Length >= 1 && !part.Contains(" "));

        //public bool Handle(Subject part)
        //{
        //    throw new NotImplementedException();
        //}
        public WordHandler(T Subject, int Position)
        {
            this.Subject = Subject;
            this.Position = Position;


        }

        public bool Handle(T part)
        {
            if (typeof(T) == typeof(string))
            {
                if (part.ToString().Length >= 1 && 
                    !part.ToString().Contains(" "))
                {
                    Console.WriteLine("WordHandler is true");
                    return true;
                }
            }
            return false;
            //ternary 
        }
    }
}
