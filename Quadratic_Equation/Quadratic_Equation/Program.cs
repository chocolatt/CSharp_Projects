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
            string filename = @"D:\Install\Github\repository\Quadratic_Equation\empty.txt";

            //if (args.Count() != 2)
            //{
            //    Console.WriteLine("Usage GLTest <in> <out>");
            //    Console.ReadLine();
            //    return;
            //}

            //string inFilePath = args[0];
            //if (!File.Exists(inFilePath))
            //{
            //    Console.WriteLine("File not exists");
            //    Console.ReadLine();
            //    return;
            //}

            FileOp.ReadFromFile(filename);
            var param = FileOp.ReadFromFile(filename);
            var result = MathCalculation.QuadraticEquation(param[0], param[1], param[2]);
            // 2,3,1 - (-0,5;1) //1,5,6 - (-2;-3) // -9,6,-1 - (0,(3)) //1,-2,7 - (no determination)
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
