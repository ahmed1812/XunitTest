using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTest
{
    public class InterViewTest
    {
        public int Sum(int[] ints) 
        {
            int sum = 0;
            foreach (int i in ints) 
            {
                sum+= i;
            }
            return sum;
        }
        public int MultNum(int a, int b) 
        {
            int k = 1;
            int sum = 0;
            while (k <= b)
            {
                sum+= a;
                k++;
            }
            return sum;
        }
    }
}
