using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302200052
{
    internal class HaloGeneric<T>
    {
        public void SapaUser(T x)
        {
            Console.WriteLine("halo " + x);
        }
    }
}
