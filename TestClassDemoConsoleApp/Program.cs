using System;

namespace TestClassDemoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string xs = Console.ReadLine();
            string ys = Console.ReadLine();
            string zs = Console.ReadLine();

            int x = Convert.ToInt32(xs);
            int y = Convert.ToInt32(ys);
            int z = Convert.ToInt32(zs);

            if (x > y)
            {
                if (x > z)
                    Console.WriteLine(x);
                else
                    Console.WriteLine(z);
            }
            else
            {
                if (y > z)
                    Console.WriteLine(y);
                else
                    Console.WriteLine(z);
            }
        }
    }
}
