using System;
using System.Collections.Generic;

namespace DataStructureEducation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Generated array: ");
            CreateArrayWithRandomNumbers createArrayWithRandomNumbers = new CreateArrayWithRandomNumbers();
            int[] numberArray = createArrayWithRandomNumbers.RandomArrayGenerate(10);
            PrintArray(numberArray);

            Console.WriteLine("Numbers much than 50:");
            SelectNumberMoreThen selectNumberMoreThen = new SelectNumberMoreThen();
            int[] numbersMoreThen = selectNumberMoreThen.NumbersMoreThen(numberArray);
            PrintArray(numbersMoreThen);

            Console.WriteLine("Numbers multiplicity of 3");
            SelectNumbersMultiplicity selectNumbersMultiplicity = new SelectNumbersMultiplicity();
            int[] numbersMultiplicity = selectNumbersMultiplicity.NumbersMultiplicity(numberArray);
            PrintArray(numbersMultiplicity);

            Console.WriteLine("Upside down");
            RevertArray revertArray = new RevertArray();
            int[] upsideDownArray = revertArray.UpsideDown(numberArray);
            PrintArray(upsideDownArray);

            Console.WriteLine("Even\\Odd Count");
            CountEvenOddNumbers countEvenOddNumbers = new CountEvenOddNumbers();
            Dictionary<string, int> evenOdd = countEvenOddNumbers.EvenOddCount(numberArray);

            foreach (var result in evenOdd)
            {
                Console.WriteLine(result.Key + " " + result.Value);
            }
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}