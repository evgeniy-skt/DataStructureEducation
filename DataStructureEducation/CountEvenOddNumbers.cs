using System.Collections.Generic;

namespace DataStructureEducation
{
    public class CountEvenOddNumbers
    {
        public Dictionary<string, int> EvenOddCount(int[] numberArray)
        {
            Dictionary<string, int> dictionaryEvenOddCount = new Dictionary<string, int>();
            int evenCount = 0;
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] % 2 == 0)
                {
                    evenCount += 1;
                }
            }
            dictionaryEvenOddCount.Add("Count even numbers", evenCount);
            dictionaryEvenOddCount.Add("Count odd numbers", numberArray.Length - evenCount);

            return dictionaryEvenOddCount;
        }
    }
}