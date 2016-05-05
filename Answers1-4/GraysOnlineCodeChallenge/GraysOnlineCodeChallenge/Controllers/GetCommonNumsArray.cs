using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraysOnlineCodeChallenge.Controllers;

namespace GraysOnlineCodeChallenge.Controllers
{
    public class GetCommonNumsArray
    {

        //this function takes an array of integers and returns an array of most common number - Question 4
        public List<int> GetCommonNumArray(List<int> l1)
        {
            List<int> maxList = new List<int> { };
            try
            {

                int maxCount = -1;

                foreach (var item in l1.GroupBy(i => i)
                               .Select(group => new
                               {
                                   itemNum = group.Key,
                                   Count = group.Count()
                               })
                               .OrderByDescending(x => x.Count))
                {
                    if (item.Count < maxCount && maxCount != -1) break;

                    maxCount = item.Count;
                    maxList.Add(item.itemNum);
                }
            }
            catch (Exception ex)
            {
                ex.ToString(); // Exception log
            }
            return maxList;

        }
    }
}
