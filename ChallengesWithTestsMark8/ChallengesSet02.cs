using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z');
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int elementcount = vals.Length;

            if (elementcount % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }

            double minnum = numbers.Min();
            double maxnum = numbers.Max();
            double total;
            total = minnum + maxnum;
            return total;





        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var length1 = str1.Count();
            var length2 = str2.Count();
            if (length1 < length2)
            {
                return length1;
            }
            else
            {
                return length2;
            }
        }


        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sum = numbers.Sum();
            return sum;
        }

        public int SumEvens(int[] numbers)
        {

            int evens = 0;

            if (numbers == null)
            {
                return 0;
            }
            foreach (int num1 in numbers)
            {
                if (num1 % 2 == 0)
                {
                    evens += num1;
                }

            }

            return evens;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            var sum = numbers.Sum();

            if (sum % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {

            if (number < 0)
            {
                return 0;
            }

            int[] count = Enumerable.Range(0, Convert.ToInt32(number)).ToArray();
            List<int> positivesodds = new List<int>();

            foreach (int num in count)
            {
                if (num % 2 != 0)
                {
                    positivesodds.Add(num);
                }

            }

            return positivesodds.Count;
        }

    }  

}
