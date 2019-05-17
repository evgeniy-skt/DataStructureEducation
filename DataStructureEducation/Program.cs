using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace DataStructureEducation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random randomNumber = new Random();
            int n = 10;
            int[] numberArray = new int[n];
            Console.WriteLine("Random array:");
            for (int i = 0; i < n; i++)
            {
                numberArray[i] = randomNumber.Next(1,100);
                Console.WriteLine(numberArray[i]);
            }

            Console.WriteLine("Numbers much than 50:");
            List<int> fromArrayToList = new List<int>();
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] > 50)
                {
                    var result = numberArray[i];
                    fromArrayToList.Add(result);
                }
            }
            //TODO Уточнить у Паши что я такое сделал
            fromArrayToList.ForEach(i => Console.WriteLine("{0}\t", i));

            Console.WriteLine("Numbers multiplicity of 3");
            List<int> multiplicity = new List<int>();
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] % 3 == 0)
                {
                    var result = numberArray[i];   
                    multiplicity.Add(result);
                }
            }
            multiplicity.ForEach(i => Console.WriteLine("{0}\t", i));
            
            Console.WriteLine("Upside down");
            int[] numberArrayForCopy = new int[n];
            int i1, j;
            for (i1 = 0, j = numberArray.Length-1; i1 < numberArray.Length; i1++, j--)
            {
                numberArrayForCopy[j] = numberArray[i1];
            }

            for (int i = 0; i < numberArrayForCopy.Length; i++)
            {
                Console.WriteLine(numberArrayForCopy[i]);
            }
            
            Console.WriteLine("Even\\Odd Count");
            Dictionary<string, int> dictionaryEvenOddCount = new Dictionary<string, int>();
            int evenCount = 0;
            int oddCount = 0;
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] % 2 == 0)
                {
                    evenCount += 1;
                }
            }
            dictionaryEvenOddCount.Add("Count even", evenCount);
            dictionaryEvenOddCount.Add("Count odd", numberArray.Length - evenCount);
            foreach (KeyValuePair<string, int> oddCount1 in dictionaryEvenOddCount)
            {
                Console.WriteLine("Key = {0}, Value = {1}", 
                    oddCount1.Key, oddCount1.Value);
            }
            Console.WriteLine();
        }
    }
}