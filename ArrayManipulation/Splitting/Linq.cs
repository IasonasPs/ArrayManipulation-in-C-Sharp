using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayManipulation.Services;

namespace ArrayManipulation.Splitting
{
    internal class Linq
    {
        //*************************************
        //Enumerable.Take() method returns a supplied number of elements from the start of a sequence
        //
        //Enumerable.Skip() method skips the supplied number of items in a sequence.
        //
        //*************************************

        public static List<int[]> Split(int[] array)
        {
            #region mid for Odd or Even array length
            int mid = FindMidOfArray.Find(array);
            #endregion

            int[] firstHalf = array.Take(mid).ToArray();
            int[] secondHald = array.Skip(mid).ToArray();

            List<int[]> result = new List<int[]>();
            result.Add(firstHalf);
            result.Add(secondHald);

            return result;
        }
    }
}
