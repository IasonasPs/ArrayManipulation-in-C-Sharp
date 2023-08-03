using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayManipulation.Services;

namespace ArrayManipulation.Splitting
{
    internal class Array_Copy
    {
        //*****************************************************************************
        //
        //Array.Copy method copies a range of elements from an array to another array.
        //
        //*****************************************************************************

        public static List<int[]> Split(int[] array)
        {

            int mid = FindMidOfArray.Find(array);

            int[] firstHalf = new int[mid];
            int[] secondHalf = new int[array.Length - mid];

            Array.Copy(array, 0, firstHalf, 0, mid);
            Array.Copy(array, mid, secondHalf, 0, secondHalf.Length);

            var resultList = new List<int[]>();

            resultList.Add(firstHalf);
            resultList.Add(secondHalf);

            return resultList;
        }

    }
}
