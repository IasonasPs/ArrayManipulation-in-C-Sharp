using System.Diagnostics.Metrics;

namespace ArrayManipulation.Services
{
    internal static class PrintList
    {

        internal static void print(List<int[]> List)
        {
            List
                .Select((array, index) => new { ElementNumber = index + 1, array })
                .ToList()
                .ForEach(item => {
                    Console.WriteLine($"Array {item.ElementNumber}");
                    Console.WriteLine("*****************************");
                    item.array
                    .ToList()
                    .ForEach(element => Console.WriteLine(element));
                    Console.WriteLine("*****************************");
                });
        }
    }
}

