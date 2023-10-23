using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;
            if(string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }
            if (ignoreCase)
            {
                word = word.ToLower();
                List<string> lc = words.Select (x => x.ToLower()).ToList();
                containsWord = lc.Contains(word);
            }
            else
            {
                var wordsList = words.ToList();
                containsWord = wordsList.Contains(word);
            }
            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num == null || num == 0 || num == 1 || num == -1)
            {
                return false;
            }
            if (num > 0)
            {
                for (int i = 2; i < num; i++) 
                {
                    if(num % i == 0)
                    {
                        return false;
                    }
                }
            return true;
            }
            else
            {
                for (int i = num + 1; i < 0; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uindex;
            for(int i = 0; i < str.Length; i++)
            {
                uindex = true;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uindex = false;
                    }
                }
                if(uindex)
                {
                    index = i;
                }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;
                for (var j = i+1; j < numbers.Length; j++) 
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }
                    else
                    {
                        currentCount++;
                    }
                }
                if (currentCount > count)
                {
                    count = currentCount;
                }
            }
            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> result = new List<double>();
            if (n <= 0 || elements == null)
            {
                return result.ToArray();
            }
            for (int i = n -1; i < elements.Count(); i += n)
            {
                result.Add(elements[i]);
            }
            return result.ToArray();
        }
    }
}
