using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
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
                return 0.0;
            }
            else
            {
                double lowest = numbers.Min();
                double highest = numbers.Max();
                return lowest + highest;
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
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                int solution = 0;
                foreach (int number in numbers)
                {
                    solution += number;
                }
                return solution;
            }
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                int solution = 0;
                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        solution += number;
                    }
                }
                return solution;
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            else
            {
                int sum = 0;
                foreach (int number in numbers)
                {
                    sum += number;
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
            long count = 0;
            for(long i = number-1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
