using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please, enter there parametrs -a, b and c ");
            var result = QE.QuadraticEquation(1, -2, 7);
            // 2,3,1 - (-0,5;1) //1,5,6 - (-2;-3) // -9,6,-1 - (0,(3)) //1,-2,7 - (no determination)
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
