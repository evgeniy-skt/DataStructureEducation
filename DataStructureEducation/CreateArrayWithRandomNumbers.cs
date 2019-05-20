using System;

namespace DataStructureEducation
{
    public class CreateArrayWithRandomNumbers
    {
        public int[] RandomArrayGenerate(int arrayLength)
        {
            Random randomNumber = new Random();
            int[] numberArray = new int[arrayLength];
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = randomNumber.Next(1,100);
            }

            return numberArray;
        }
    }
}