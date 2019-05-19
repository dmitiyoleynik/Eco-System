using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Ocean ok = new Ocean(70, 20);
            ok.Display();


            for (int i = 0; i < 1000; i++)
            {
                ok.Run();
                Console.Clear();
                ok.Display();
                Console.ReadKey();
                ok.KillFish(new Coordinate(2, 2));
               
            }

        }
    }
}
