using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace DataStructureEducation
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateArrayWithRandomNumbers createArrayWithRandomNumbers = new CreateArrayWithRandomNumbers();
            SelectNumberMoreThen selectNumberMoreThen = new SelectNumberMoreThen();
            SelectNumbersMultiplicity selectNumbersMultiplicity = new SelectNumbersMultiplicity();
            RevertArray revertArray = new RevertArray();
            
            Console.WriteLine("Generated array: ");
            int[] numberArray = createArrayWithRandomNumbers.RandomArrayGenerate(10);
            
            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine(numberArray[i]);
            }
            
            Console.WriteLine("Numbers much than 50:");
            int[] numbersMoreThen = selectNumberMoreThen.NumbersMoreThen(numberArray);
            
            for (int i = 0; i < numbersMoreThen.Length; i++)
            {
                Console.WriteLine(numbersMoreThen[i]);
            }
            
            Console.WriteLine("Numbers multiplicity of 3");
            int[] numbersMultiplicity = selectNumbersMultiplicity.NumbersMultiplicity(numberArray);

            for (int i = 0; i < numbersMultiplicity.Length; i++)
            {
                Console.WriteLine(numbersMultiplicity.Length);
            }
            
            Console.WriteLine("Upside down");
            int[] upsideDownArray = revertArray.UpsideDown(numberArray);

            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine(upsideDownArray[i]);
            }
            
            Console.WriteLine("Even\\Odd Count");
            Dictionary<string, int> dictionaryEvenOddCount = new Dictionary<string, int>();
            int evenCount = 0;
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