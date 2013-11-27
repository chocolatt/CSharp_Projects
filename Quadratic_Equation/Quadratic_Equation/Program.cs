using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"D:\Install\Github\repository\Quadratic_Equation\parameters.txt";
            FileOp.ReadFromFile(filename);
       
            var result = MathCalculation.QuadraticEquation(1, -2, 7);
            // 2,3,1 - (-0,5;1) //1,5,6 - (-2;-3) // -9,6,-1 - (0,(3)) //1,-2,7 - (no determination)
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
