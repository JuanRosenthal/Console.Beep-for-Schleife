using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {

            Start:

            Console.WriteLine("wie oft soll es piepsen?");

            
                double b = Convert.ToDouble(Console.ReadLine());
        
           

            for (double a = 1; a <= b; a = a + 1)
            {
                double d = b - a;                
                Console.WriteLine("beeps verbleibend: "+ d);
                Console.Beep();
                Console.Clear();
            }
            Console.Clear();            
            goto Start;

        }
    }
}
