using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainofresponsibility2
{
    internal class Subject
    {
        public List<string> Parts { get; set; }
        public Subject()
        {
            Parts.Add("Kalhspera");
            Parts.Add(" ");
            Parts.Add("kai");
            Parts.Add("  ");
            Parts.Add("kalh");
            Parts.Add("    ");
            Parts.Add("bradia");
        }
    }
}
