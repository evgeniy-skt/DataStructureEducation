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
            for (int i = 0; i < n; i++)
            {
                numberArray[i] = randomNumber.Next(1,100);
                Console.WriteLine(numberArray[i]);
            }

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
            fromArrayToList.ForEach(i => Console.Write("{0}\t", i));
        }
    }
}