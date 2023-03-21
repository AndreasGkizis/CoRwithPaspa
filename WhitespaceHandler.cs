using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainofresponsibility2
{
    internal class WhitespaceHandler<T> : IHandler<T> //IHandler<Subject>, IHandler<string>
    {
        /// <summary>
        /// Retuns true only if all of the chars in the part are whitespaces
        /// and less than 3
        /// </summary>
        /// <param name="part"></param>
        /// <returns></returns>
        //public bool Handle(string part)=> (
        //    part.Length<=3 && 
        //    part.All(x=>x.Equals(" "))
        //);

        //public bool Handle(Subject part)
        //{
        //    throw new NotImplementedException();
        //}
        public T Subject { get; set; }
        public int Position { get; set; }
        public WhitespaceHandler(T Subject, int Position)
        {
            this.Subject = Subject;
            this.Position = Position;
        }
        public bool Handle(T part)
        {
            if (typeof(T) == typeof(string))
            {
                if (part.ToString().Length <= 3 &&
                part.ToString().All(x => x.Equals(" ")))
                {
                    Console.WriteLine("WhitespaceHandler is true");
                    return true;
                }
            }
            return false;
            //ternary 
        }
    }
}

