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
            Ocean ok = new Ocean(30, 30);
            ok.Display();


            for (int i = 0; i < 1000; i++)
            {
                ok.Run();
                Console.Clear();
                ok.Display();
                Console.ReadKey();
                ok.KillFish(new Coordinate(2, 2));
            }

            //Console.WriteLine();

            //for (int i = 0; i < 69; i++)
            //{

            //    ok.Swop(new Coordinate(3, i), new Coordinate(2, i));

            //}
            //ok.Display();

            //Console.WriteLine();

            //for (int i = 0; i < 69; i++)
            //{

            //    ok.Swop(new Coordinate(3, i), new Coordinate(2, i));

            //}
            //ok.Display();
        }
    }
}
