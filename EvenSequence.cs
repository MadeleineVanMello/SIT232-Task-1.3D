// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Even numbers between 1 and 20:");
//         foreach (var n in EvenSequence(1, 20))
//         {
//             Console.WriteLine(n);
//             Console.WriteLine("\nPress any key to continue...");
//             Console.ReadKey();
//         }

//         Console.WriteLine("\nPress any key to exit...");
//         Console.ReadKey();
//     }

//     // Iterator method
//     public static IEnumerable<int> EvenSequence(int first, int last)
//     {
//         for (int n = first; n <= last; n++)
//         {
//             if (n % 2 == 0)
//             {
//                 Console.WriteLine($"\nyielding {n}");
//                 yield return n;
//             }
//         }
//     }
// }