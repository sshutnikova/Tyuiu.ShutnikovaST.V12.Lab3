using System;
using System.Linq;

namespace SolveArray.Lib
{
    public class Array
    {
        public int CalculateMinimum(int[] array)
        {
            return array.Min();
        }

        public int CalculateMaximum(int[] array)
        {
            return array.Max();
        }

        public double CalculateAverage(int[] array)
        {
            return array.Average();
        }

        public double CalculateMedian(int[] array)
        {
            System.Array.Sort(array);
            int l = array.Length;
            if (l % 2 == 0)
            {
                return (array[l / 2 - 1] + array[l / 2]) / 2.0;
            }
            else
            {
                return array[l / 2];
            }
        }

        public int CalculateNumberOfEven(int[] array)
        {
            int count = 0;
            for (int i = 0;  i < array.Length; i++)
            {
                if (array[i] % 2 == 0) count++;
            }
            return count;
        }

        public int CalculateNumberOfOdd(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0) count++;
            }
            return count;
        }

        public int SignsOfDivisibilityByTwo(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) count++;
            }
            return count;
        }

        public int SignsOfDivisibilityByThree(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0) count++;
            }
            return count;
        }

        public int SignsOfDivisibilityByFive(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 5 == 0) count++;
            }
            return count;
        }

        public int SignsOfDivisibilityByTen(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 10 == 0) count++;
            }
            return count;
        }
    }
}