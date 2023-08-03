namespace ArrayManipulation.Services
{
    internal class FindMidOfArray
    {

        internal static int Find(int[] array)
        {
            int mid;
            if (array.Length % 2 == 0)
            {
                mid = array.Length / 2;
            }
            else
            {
                mid = (array.Length - 1) / 2;
            }

            return mid;
        }
    }
}