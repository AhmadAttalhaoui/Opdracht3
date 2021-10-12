using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Persoon
    {
        public static int Id {  get; set; } 
        public static int counter = 0;
        public string Name {  get; set; }

        public Persoon(string name)
        {
            counter = Id;
            Name = name;
            counter++;
        }
    }
}
