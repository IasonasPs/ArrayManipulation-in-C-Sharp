using System.Threading.Channels;
using ArrayManipulation.Services;
using ArrayManipulation.Splitting;

namespace ArrayManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 1, 2, 3, 4, 5, };
            Console.WriteLine("- - - - - - - - - - - - - - - ");

            //var LinqList = Linq.Split(array);
            //PrintList.print(LinqList);

            Console.WriteLine("- - - - - - - - - - - - - - - ");

            var Array_Copy_List = Array_Copy.Split(array);
            PrintList.print(Array_Copy_List);

            Console.WriteLine("- - - - - - - - - - - - - - - ");
            var RangeNotationList = RangeNotation.Split(array);
            PrintList.print(RangeNotationList);
            Console.WriteLine("- - - - - - - - - - - - - - - ");
        }
    }
}