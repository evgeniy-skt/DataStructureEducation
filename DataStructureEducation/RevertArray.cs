namespace DataStructureEducation
{
    public class RevertArray
    {
        public int[] UpsideDown(int[] numberArray)
        {
            int[] numberArrayForCopy = new int[10];
            int i1, j;
            for (i1 = 0, j = numberArray.Length - 1; i1 < numberArray.Length; i1++, j--)
            {
                numberArrayForCopy[j] = numberArray[i1];
            }

            return numberArrayForCopy;
        }
    }
}