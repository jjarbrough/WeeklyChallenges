using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            bool cont = false;
            int finalNumber = startNumber;
            while (!cont)
            {
                if (startNumber % n == 0 && finalNumber != startNumber)
                {
                    cont = true;
                }
                else
                {
                    startNumber++;
                }
            }
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach(Business business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                {
                return false;
                }
            else
            {
            int[] inAscending = numbers.OrderBy(x => x).ToArray();
            for (int i = 0; i< numbers.Length; i++)
            {
                if (inAscending[i] == numbers[i])
                {
                }
                else
                {
                return false;
                }
            }
            return true;
            }
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0 && i != (numbers.Length -1))
                {
                    sum += numbers[i + 1];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }
            else
            {
            var listWords = words.ToList();
            for (int i = listWords.Count - 1; i >= 0; i--)
            {
                    listWords[i] = listWords[i].Trim();
             if (listWords[i] == " " || listWords[i] == "")
                {
                    listWords.RemoveAt(i);
                }
            }
            string sentence = string.Join(" ", listWords);
                if (sentence.Length > 1)
                {
                    sentence += ".";
                }
            return sentence;
            }
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> result = new List<double>();
            int j = 0;
            if (elements == null)
            {
                return result.ToArray();
            }
            else
            {
            for (int i = 3; i < elements.Count; i+=4)
            {
                result.Add(elements[i]);
            }
            return result.ToArray();
            }
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == targetNumber && i != j)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
