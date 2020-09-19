using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201606008_이무비_2주차
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("변수1");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("변수2");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("연산자");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.Write(n1 + n2);
                    break;
                case "-":
                    Console.Write(n1 - n2);
                    break;
                case "*":
                    Console.Write(n1 * n2);
                    break;
                case "/":
                    Console.Write(1 / n2);
                    break;
            }

        }
    }
}
