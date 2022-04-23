using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class AssignmentClass
    {
        public string gradeCalculate(int score)
        {
            if (score >= 80 & score < 100)
                return "A";
            else if (score >= 75 && score < 80)
                return "B+";
            else if (score >= 70 && score < 75)
                return "B";
            else if (score >= 65 && score < 70)
                return "C+";
            else if (score >= 60 && score < 65)
                return "C";
            else if (score >= 55 && score < 60)
                return "D+";
            else if (score >= 50 && score < 55)
                return "D";
            else if (score >= 0 && score < 50)
                return "F";
            else 
                return "00";
        }
        public double getDistance(int x1, int y1, int x2, int y2)
        {
            double x = x2 - x1;
            double y = y2 - y1;
            double sum = Math.Pow(x, 2) + Math.Pow(y, 2);
            double result = Math.Sqrt(sum);
            return Math.Round(result, 2);
        }
        /*public int getFactorial(int n)
        {
            int fact = 1;
            for(int i = 1; i <= n; ++i)
            {
                fact *= i;
            }
            return fact;
        }
        public string checkPassword(string password)
        {
            

        }*/
    }
}
