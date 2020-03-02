using System;
using System.Collections.Generic;
using System.Text;

namespace _25Feb
{
    class ParamArray
    {
        public int AddElements(params int[] arr)
        {
            int sum = 0;

            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }
    }
}
