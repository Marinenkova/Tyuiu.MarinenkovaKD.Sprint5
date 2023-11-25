using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MarinenkovaKD.Sprint5.Task5.V28.Lib
{
    public class DataService : ISprint5Task5V28
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;
            using (StreamReader reader = new StreamReader(path))
            {
                double min = int.MaxValue;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double number = double.Parse(line);
                    if (number > 0 && number % 5 == 0 && number < min)
                    {
                        min = number;
                    }

                    
                    for (int i = 2; i <= number; i++)
                    {
                        res *= i;
                    }
                }
            }
            return res;
        }
    }
}
