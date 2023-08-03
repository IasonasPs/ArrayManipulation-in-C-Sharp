using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayManipulation.Services;

namespace ArrayManipulation.Splitting
{
    internal class RangeNotation
    {
        //***********************************************************
        //
        //Since C# 8 ,we can use the Range notation .. ,which specifies the start and end of a range as its operands.
        //The start of the range is inclusive and the end of the range is exclusive.
        //
        //***********************************************************

        public static List<int[]> Split(int[] array)
        {
            int mid = FindMidOfArray.Find(array);

            int[] firstHalf = array[0..mid];
            int[] secondHalf = array[mid..];

            List<int[]> result = new List<int[]>();
            result.Add(firstHalf);
            result.Add(secondHalf);

            return result;
        }
    }
}
