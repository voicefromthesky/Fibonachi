using System;

namespace Fibonachi
{
    class Program
    {
        static void Fibonachi (int F, int x = 0,int y = 1)
        {
            
            
            Console.Write(x +" "+ y+" ");
             
            if (F>1)
            {
                F--;
                x = y;
                y = x + y;
                Fibonachi(F);
            }


        }
        static void Main(string[] args)
        {
            //    // Fibonachi with for//
            //    Console.WriteLine("How much of Fibonachi do you want?");
            //    int F = int.Parse(Console.ReadLine()) ;
            //    int x = 0;
            //    int y = 1;
            //    int result;
            //    Console.Write(x+ " " + y + " ");
            //    for (int i = 0; i < F; i++)
            //    {
            //        result = x + y;
            //        Console.Write(y+ " ");
            //        x = y;
            //        y = result;
            //    }

            Fibonachi(8);


        }

    }
}