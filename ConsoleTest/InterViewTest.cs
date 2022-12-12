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

        public int[] SortArray(int[] a)
        {
            for (int i=0; i<a.Length; i++)
            {
                for (int j= i+1; j<a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            return a;
        }

        public int FibSwap(int n)
        {
            int a = 0;
            int b = 1;
            int sum = 0;
            int i = 1;
            while (i < n)
            {
                sum = a + b;
                a = b;
                b = sum;
                i++;
            }
            return sum;
        }

        public bool NumIsPrime(int a)
        {
            bool flag = false;
            for (int i=2; i<=a/2; i++)
            {
                if (a % i == 1)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        public bool IsPalindrome(string s)
        {
            int i = 0;
            int j = s.Length - 1;
            while (true)
            {
                if (i > j)
                {
                    return true;
                }
                char a = s[i];
                char b = s[j];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                i++;
                j--;
            }
        }

        public int UnqNum(int[] numbers)
        {
            throw new NotImplementedException();
        }
    }
}
