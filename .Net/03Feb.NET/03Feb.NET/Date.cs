using System;
using System.Collections.Generic;
using System.Text;

namespace _03Feb.NET
{
    public class Date //Demonstrating input validation through a get set property
    {
        private int _month = 7;  // Backing store

        public int Month
        {
            get => _month;
            set
            {
                if ((Month > 0) && (Month < 13))
                {
                    throw new Exception("Not between 1-12");
                }
                else
                {
                    _month = value;
                }
            }
        }
    }
}
