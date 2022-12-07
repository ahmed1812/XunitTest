using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTest
{
    public class InterViewTest
    {
        // sum array of number
        public int Sum(int[] ints) 
        {
            int sum = 0;
            foreach (int i in ints) 
            {
                sum+= i;
            }
            return sum;
        }
        //mult two numbers 
        public int Multiply(int a, int b) 
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
        public int DiffIndex(int[] arr)
        {
            int diff = 0;
            for (int i=0; i<arr.Length-1; i++) 
            {
                if (arr[i+1] - arr[i] > diff)
                {
                    diff = arr[i + 1] - arr[i];
                }
            }
            return diff;
        }

        public int[] TwoDiffArray(int[] a, int[] b)
        {
            List<int> list = new List<int>();
            for (int i=0; i< a.Length; i++)
            {
                if (a[i] == b[i])
                {
                    list.Add(a[i]);
                }
            }
            return list.ToArray();
        }
    }
}
