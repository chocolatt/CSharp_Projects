using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quadratic_Equation
{
    class MathCalculation
    {
        public static double[] QuadraticEquation(double a, double b, double c)
        {
            {
                double D;

                if (a != 0)
                {
                    D = b * b - 4 * a * c;
                    if (D < 0)
                    {
                        //if D is < 0 than QuadraticEquation has no determination
                        return new double[0];
                    }
                    else if (D == 0)
                    {
                        //if D = 0, there is always one result 
                        return new double[1] { -b / (2 * a) };
                    }
                    else
                    {
                        var x1 = (-b + Math.Sqrt(D)) / (2 * a);
                        var x2 = (-b - Math.Sqrt(D)) / (2 * a);
                        //now let's check if recieved results satisfy our equation --- ????? ти собі не довіряєш?
                        return new double[] { x1, x2 };
                    }
                }
                else if (a == 0 && b != 0)
                {
                    // b*x + c = 0
                    return new double[1] { -c / b };
                }
                else
                    // НЕ ТРЕБА НІЧОГО ПИСАТИ В КОНСОЛЬ! ЦЕЙ МЕТОД РОЗВ"ЯЗУЄ РІВНЯННЯ, А НЕ ГАДИТЬ КУДИСЬ   Console.WriteLine("Given QuadraticEquation has no determination");
                    return new double[0];
            }
        }
    }
}