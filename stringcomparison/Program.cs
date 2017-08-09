using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace stringcomparison
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Will use this code to store date/time into a List, then sort and 
             * identify which are the earliest and latest dates, without using ticks
            **/
            var dateList = new List<string>() { "08/11/2017 08/12/2017", "08/08/20171:00PM 08/10/2017" };
            List<string> startDatesList = new List<string>();
            List<string> endDatesList = new List<string>();
            foreach (var dates in dateList)
            {
                var splitDate = dates.Split(' ');
                string startDate = splitDate[0];
                string endDate = splitDate[1];
                startDatesList.Add(startDate);
                endDatesList.Add(endDate);
            }
            startDatesList.Sort();
            Console.WriteLine("The start dates are: \n");
            foreach (var dates in startDatesList)
            {
                Console.WriteLine(dates.ToString());
            }
            Console.WriteLine("\nThe earliest start date is {0}", startDatesList[0].ToString());
            endDatesList.OrderByDescending(i => i);
            Console.WriteLine("The end dates are: \n");
            foreach (var dates in endDatesList)
            {
                Console.WriteLine(dates.ToString());
            }
            Console.WriteLine("\nThe latest end date is {0}", endDatesList[0].ToString());
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

      
    }


}
