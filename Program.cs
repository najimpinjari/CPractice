using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPractice
{
    public class Program
    {
        static void Main(string[] args)
        {

                int a = 5;
                 int b = 10;

            int adddin = Calculato.Add(a, b);

            Console.WriteLine(adddin);

            int sub = Calculato.substrac(a, b);

            Console.WriteLine(sub);

            int mal = Calculato.Maltiply(a, b);

            Console.WriteLine(mal);


            int div = Calculato.divide(a,b);

            Console.WriteLine(div);

            Console.ReadLine();
           

        }
    }

    public static class Calculato
    {

        public static int Add(int a , int b ) => a + b;
        public static int substrac(int a , int b ) => a - b;
        public static int Maltiply(int a , int b ) => a * b;
        public static int divide(int a , int b ) => a / b;

    }
}
