using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysOnlineCodeChallenge.Controllers
{
   public class CheckIsNullorEmpty
    {
        //Checking if the string IsNUllOrEmpty - Question 1
        public bool valIsNullorEmpty(String s)
        {
            try
            {

                return (s.Length == 0) ? true : false;
            }
            catch (NullReferenceException e)
            {
                return true;

            }

        }
    }
}
