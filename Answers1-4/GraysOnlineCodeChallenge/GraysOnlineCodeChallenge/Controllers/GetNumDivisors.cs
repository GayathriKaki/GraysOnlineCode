using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysOnlineCodeChallenge.Controllers
{
   public class GetNumDivisors
    {
        //Returns all divisors of a number - Question 2
        public IEnumerable<int> GetDivisors(int num)
        {
            IEnumerable<int> lstDivisors;

            lstDivisors = from i in Enumerable.Range(1, num / 2)
                          where num % i == 0
                          select i;

            var outlst = lstDivisors.Concat(new int[] { num });


            return outlst;
        }
    }
}
