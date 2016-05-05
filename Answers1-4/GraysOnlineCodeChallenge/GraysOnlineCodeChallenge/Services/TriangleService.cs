using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace GraysOnlineCodeChallenge.Services
{
   
    public class TriangleService
    {
        public TriangleType GetTriaType(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return TriangleType.Error;
            }


            if (a + b <= c || a + c <= b || b + c <= a)
            {
                return TriangleType.Error;
            }


            if (a == b && b == c)
            {
                return TriangleType.Equilateral;
            }


            if (a == b || b == c || a == c)
            {
                return TriangleType.Isosceles;
            }


            return TriangleType.Scalene;
        }

    }

    public enum TriangleType
    {

        [EnumMember]
        Error,


        [EnumMember]
        Equilateral,


        [EnumMember]
        Isosceles,


        [EnumMember]
        Scalene,
    }
}
