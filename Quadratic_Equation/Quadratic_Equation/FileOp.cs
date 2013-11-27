using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace Quadratic_Equation
{
    class FileOp
    {
        public static void ReadFromFile(string filename)
        {
           
            //FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
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
            int a = Convert.ToInt32(parametersList[0]);
            int b = Convert.ToInt32(parametersList[1]);
            int c = Convert.ToInt32(parametersList[2]);
        }
    }
}

