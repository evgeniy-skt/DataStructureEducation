using System;
using System.Collections.Generic;

namespace DataStructureEducation
{
    public class SelectNumberMoreThen
    {
        public int[] NumbersMoreThen(int[] numberArray)
        {
            List<int> fromArrayToList = new List<int>();
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] > 50)
                {
                    var result = numberArray[i];
                    fromArrayToList.Add(result);
                }
            }

            void PrintArrayToConsole(int i)
            {
                Console.WriteLine("{0}\t", i);
            }
            //TODO Уточнить у Паши что я такое сделал
            fromArrayToList.ForEach(PrintArrayToConsole);
            return fromArrayToList.ToArray();
        }
        }
}