using System;

namespace tpmodul4_1302200052
{
    class Program
    {

        static void Main(string[] args)
        {
            HaloGeneric<string> halo = new HaloGeneric<string>();
            String x = "glen ";
            halo.SapaUser(x);
            DataGeneric<String> data = new DataGeneric<string>("1302200052");
            data.PrintData();

        }
    }


}