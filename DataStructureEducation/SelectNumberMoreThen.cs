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
            return fromArrayToList.ToArray();
        }
        }
}