using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Reaction Game ===\n");

        foreach (var step in ReactionGame())
        {
            Console.WriteLine(step);
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    // Iterator acting as a real-time state machine
    public static IEnumerable<string> ReactionGame()
    {
        yield return "[State: InsertCoin] Please insert a coin...";
        WaitForKey();

        yield return "[State: Ready] Please press ENTER to start...";
        WaitForEnter();

        yield return "[State: WaitingForSignal] Please wait...";
        RandomDelay();

        yield return "[State: SignalOn] GO! Please press any key!";

        int reaction = MeasureReactionTime();

        if (reaction < 150)
        {
            yield return $"[State: Result] Too fast! Your reaction time was {reaction}ms. You reacted before the signal.";
        }
        else if (reaction > 2000)
        {
            yield return $"[State: Result] Too slow! Your reaction time was {reaction}ms.";
        }
        else
        {
            yield return $"[State: Result] Well done! Your reaction time was {reaction}ms.";
        }

        yield return "[State: End] Game over!";
    }

    // Wait for any key
    private static void WaitForKey()
    {
        Console.WriteLine("(Please press any key...)");
        Console.ReadKey(true);
        Console.WriteLine();
    }

    // Wait specifically for ENTER
    private static void WaitForEnter()
    {
        Console.WriteLine("(Please press ENTER...)");
        while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        Console.WriteLine();
    }

    // Random delay before the GO signal
    private static void RandomDelay()
    {
        var rand = new Random();
        int delay = rand.Next(1000, 3000); // 1–3 seconds
        System.Threading.Thread.Sleep(delay);
    }

    // Measure real reaction time using Stopwatch
    private static int MeasureReactionTime()
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        Console.ReadKey(true); // user reacts

        stopwatch.Stop();
        return (int)stopwatch.ElapsedMilliseconds;
    }
}