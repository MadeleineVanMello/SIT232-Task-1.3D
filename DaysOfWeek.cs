// using System.Collections;

// class Program
// {
//     static void Main()
//     {
//         var days = new DaysOfWeek();

//         Console.WriteLine("Iterating through DaysOfWeek:");
//         foreach (var day in days)
//         {
//             Console.WriteLine(day);
//             Console.WriteLine("\nPress any key to continue...");
//             Console.ReadKey();
//         }

//         Console.WriteLine("\nPress any key to exit...");
//         Console.ReadKey();
//     }
// }

// // Custom collection with iterator
// public class DaysOfWeek : IEnumerable<string>
// {
//     private string[] days =
//         { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

//     public IEnumerator<string> GetEnumerator()
//     {
//         foreach (var day in days)
//         {
//             Console.WriteLine($"\nyielding {day}");
//             yield return day;
//         }
//     }

//     IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
// }