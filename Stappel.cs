using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Stappel<T>
    {
        List<T> lijst = new List<T>();

        public void addLijst(T add)
        {
            lijst.Add(add);
        }

        public T RemoveLijst()
        {
            if(lijst.Count == 0)
                throw new StackOverflowException();
            T del = lijst[0];
            lijst.RemoveAt(0);
            return del;
        }

        public void Delete(T deleteAll)
        {
            lijst.Clear();
        }

        public override string? ToString()
        {
            return String.Join(",", lijst);
        }

        public bool isAanwezig(T iets)
        {
            if (lijst.Contains(iets))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            
    }
}
