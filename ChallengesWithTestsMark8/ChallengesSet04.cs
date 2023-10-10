using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
                else
                {
                    sum -= numbers[i];
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortest = 0;
            int str1Length = str1.Length;
            int str2Length = str2.Length;
            int str3Length = str3.Length;
            int str4Length = str4.Length;
            int[] lengths = new int[4] {str1Length, str2Length, str3Length, str4Length};
            shortest = lengths.Min();
            return shortest;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] numbers = new int[4] { number1, number2, number3, number4 };
            return numbers.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if ((sideLength1 + sideLength2) > sideLength3 && (sideLength2 + sideLength3) > sideLength1 && (sideLength1 + sideLength3) > sideLength2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            int i = 0;
            double j = 0;
            bool isANumber = int.TryParse(input, out i);
            bool isADouble = double.TryParse(input, out j);
            if (isANumber || isADouble)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int i = 0;
            foreach(object obj in objs)
            {
                if (obj == null)
                {
                    i++;
                }
            }
            if (i > (objs.Length / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0 )
            {
                return 0;
            }
            else
            {
                double sum = 0;
                double j = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        sum += numbers[i];
                        j++;
                    }
                }
                if (j == 0) 
                {
                    return 0;
                }
                double solution = sum / j;
                return solution;
            }
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
                int result = 1;
                for (int i = number; i > 0; i--)
                {
                    result *= i;
                }
               return result;
        }
    }
}
