using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace Quadratic_Equation
{
    class FileOp
    {
        public static double[] ReadFromFile(string filename)
        {
            double[] newParams = new double[3];
            try
            {
                FileStream fs = File.OpenRead(filename);

                List<string> parametersList = new List<string>();
                using (StreamReader reader = new StreamReader(fs))
                {
                    string param;
                    while ((param = reader.ReadLine()) != null)
                    {
                        parametersList.Add(param);
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    newParams[i] = Convert.ToDouble(parametersList[i]);
                }
            }
            catch (FileNotFoundException fnf)
            {
                Console.WriteLine(fnf.Message);
                Console.WriteLine("Please, verify that expected file exists in given path");
                //throw;
            }
            return newParams;
           }
    }
}

