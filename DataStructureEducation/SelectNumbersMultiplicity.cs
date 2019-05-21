using System;
using System.Collections.Generic;

namespace DataStructureEducation
{
    public class SelectNumbersMultiplicity
    {
        public int[] NumbersMultiplicity(int[] numberArray)
        {
            List<int> multiplicity = new List<int>();
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] % 3 == 0)
                {
                    var result = numberArray[i];   
                    multiplicity.Add(result);
                }
            }
            return multiplicity.ToArray();
        }
    }
}