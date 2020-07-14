using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace WeeklyChallenges
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            bool result = Char.IsLetter(c);
            return result;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int number = vals.Length;

            if (number % 2 == 0)
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
            bool result = (number % 2 == 0) ? true : false;
            return result;
        }

        public bool IsNumberOdd(int num)
        {
            bool result = (num % 2 == 0) ? false : true;
            return result;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                if (numbers.Count() != 0)
                {
                    double min = numbers.Min();
                    double max = numbers.Max();
                    double sum = min + max;
                    return sum;
                }
                return 0;
            }

   
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
            else
            {
                return str1.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                foreach (int item in numbers)
                {
                    sum += item;
                }
                return sum;
            }
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                foreach (int item in numbers)
                {
                    if (item % 2 == 0)
                    {
                        sum += item;
                    }
                    else if (item == 0)
                    {
                        return 0;
                    }
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return false;
            }
            else
            {
                foreach (int item in numbers)
                {
                    sum += item;
                }
                if (sum % 2 == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long odds = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 2 == 1)
                {
                    odds++;
                }
            }
         return odds;
        }
    }
}
