using System;
using System.Collections.Generic;

namespace DataStructureEducation
{
    class Program
    {
        static void Main()
        {
            CreateArrayWithRandomNumbers createArrayWithRandomNumbers = new CreateArrayWithRandomNumbers();
            SelectNumberMoreThen selectNumberMoreThen = new SelectNumberMoreThen();
            SelectNumbersMultiplicity selectNumbersMultiplicity = new SelectNumbersMultiplicity();
            RevertArray revertArray = new RevertArray();
            CountEvenOddNumbers countEvenOddNumbers = new CountEvenOddNumbers();

            Console.WriteLine("Generated array: ");
            int[] numberArray = createArrayWithRandomNumbers.RandomArrayGenerate(10);
            PrintArray(numberArray);

            Console.WriteLine("Numbers much than 50:");
            int[] numbersMoreThen = selectNumberMoreThen.NumbersMoreThen(numberArray);
            PrintArray(numbersMoreThen);

            Console.WriteLine("Numbers multiplicity of 3");
            int[] numbersMultiplicity = selectNumbersMultiplicity.NumbersMultiplicity(numberArray);
            PrintArray(numbersMultiplicity);

            Console.WriteLine("Upside down");
            int[] upsideDownArray = revertArray.UpsideDown(numberArray);
            PrintArray(upsideDownArray);

            Console.WriteLine("Even\\Odd Count");
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