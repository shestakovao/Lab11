using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения коэфициентов k и b");
            double k = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());    

            Liner liner = new Liner(k, b);
            Console.WriteLine(liner.Root());
            Console.ReadKey();  

        }
    }
}
