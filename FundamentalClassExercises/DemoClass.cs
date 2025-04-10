using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalClassExercises
{
    public class DemoClass
    {
        private DateTime todaysDate;

      
         public DemoClass()
        {
            todaysDate = DateTime.Now;

        }

        public void DisplayDate()
        {
            string dateString = todaysDate.ToString();

            Console.WriteLine(dateString);
        }
    }
}
