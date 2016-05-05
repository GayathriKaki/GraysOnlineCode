using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraysOnlineCodeChallenge.Services;
using Mathos.Exceptions;

namespace GraysOnlineCodeChallenge.Controllers
{
    public class GetTriangleArea
    {
        //Get area of Triangle -- Question 3
        public double GetTriaArea(int a, int b, int c)
        {
            double area = 0.0;
            try
            {
                TriangleService triaType = new TriangleService();

                if (triaType.GetTriaType(a, b, c) == TriangleType.Error) throw new InvalidTriangleException();

                area = Math.Sqrt((-Math.Pow(a, 4) + 2 * Math.Pow((a * b), 2) + 2 * Math.Pow((a * c), 2) - Math.Pow(b, 4) + 2 * Math.Pow((b * c), 2) - Math.Pow(c, 4))) / 4;
            }
            catch (InvalidTriangleException ex)
            {
                Console.WriteLine("Invalid Triangle"); //Exception log
            }

            return area;


        }

    }
}
