using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool isThereAFalse = false;
            foreach(var value in vals)
            {
                if (value == false)
                {
                    isThereAFalse = true;
                }
            }
            return isThereAFalse;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int sum = 0;
            for (int i = 0; i < numbers.Count(); i++)
            {
                if (numbers.ElementAt(i) % 2 != 0)
                {
                    sum += numbers.ElementAt(i);
                }
            }
            if (sum%2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool containsAtLeastOneUppercase = password.Any(char.IsUpper);
            bool containsAtLeastOneLowercase = password.Any(char.IsLower);
            bool isIntString = password.Any(char.IsDigit);
            if(containsAtLeastOneUppercase && containsAtLeastOneLowercase && isIntString)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
           var firstLetter = val.Substring(0,1);
            return firstLetter[0];
        }

        public char GetLastLetterOfString(string val)
        {
            var lastLetter = val.Substring(val.Length - 1,1);
            return lastLetter[0];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            decimal solution = dividend / divisor;
            return solution;
        }

        public int LastMinusFirst(int[] nums)
        {
            int lastIndex = nums.Length - 1;
            return nums[lastIndex] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] oddInts = new int[50];
            int j = 0;
            for(int i = 1; i < 100; i+=2)
            {
                oddInts[j] = i;
                j++;
            }
            return oddInts;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                string upper = words[i].ToUpper();
                words[i] = upper;
            }
        }
    }
}
