public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly.  Clear your mind and focus on your breathing.",
        0)
    {
    }

    public void Run()
    {
        int time = 0;
        while (time < _duration)
        {
            Console.WriteLine();
            BreatheIn();
            Console.WriteLine();
            BreatheOut();
            Console.WriteLine();
            time += 12;
        }
    }

    public void BreatheIn()
    {
        Console.CursorVisible = false; // hide cursor for better animation
        Console.Write("Breathe in...     ");
        // animation to help with visualization
        Console.Write("            1            ");
        Thread.Sleep(500);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        Console.Write("           (1)           ");
        Thread.Sleep(500);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        Console.Write("          ((2))          ");
        Thread.Sleep(500);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        Console.Write("         (((2)))         ");
        Thread.Sleep(500);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        Console.Write("        ((((3))))        ");
        Thread.Sleep(500);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        Console.Write("       (((((3))))))      ");
        Thread.Sleep(500);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        Console.Write("      ((((((4)))))))     ");
        Thread.Sleep(500);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        Console.Write("     (((((((4))))))))    ");
        Thread.Sleep(500);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        Console.Write("    ((((((((5)))))))))   ");
        Thread.Sleep(500);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        Console.Write("   (((((((((5))))))))))  ");
        Thread.Sleep(500);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        Console.Write(" (((((((((((6))))))))))) ");
        Thread.Sleep(500);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        Console.Write("((((((((((((6))))))))))))");
        Thread.Sleep(500);

// countdown replaced with animation
        //        int timeLeft = 4;
        //        for (int i = 0; i < 4; i++)
        //        {
        //            Console.Write(timeLeft);
        //            Thread.Sleep(1000);
        //            Console.Write("\b \b");
        //            timeLeft--;
        //        }
    }

    public void BreatheOut()
    {
        Console.CursorVisible = false; // hide cursor for clearer animation
        Console.Write("Now Breathe out...");
        // animation to help with visualization
        Console.Write("((((((((((((6))))))))))))");
        Thread.Sleep(500);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        Console.Write(" (((((((((((6))))))))))) ");
        Thread.Sleep(500);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        Console.Write("   (((((((((5))))))))))  ");
        Thread.Sleep(500);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        Console.Write("    ((((((((5)))))))))   ");
        Thread.Sleep(500);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        Console.Write("     (((((((4))))))))    ");
        Thread.Sleep(500);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        Console.Write("      ((((((4)))))))     ");
        Thread.Sleep(500);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        Console.Write("       (((((3))))))      ");
        Thread.Sleep(500);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        Console.Write("        ((((3))))        ");
        Thread.Sleep(500);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        Console.Write("         (((2)))         ");
        Thread.Sleep(500);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        Console.Write("          ((2))          ");
        Thread.Sleep(500);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        Console.Write("           (1)           ");
        Thread.Sleep(500);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        Console.Write("            1            ");
        Thread.Sleep(500);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        Console.WriteLine("            0            ");

//  Countdown replaced with animation
        //        int timeLeft = 6;
        //        for (int i = 0; i < 6; i++)
        //        {
        //            Console.Write(timeLeft);
        //            Thread.Sleep(1000);
        //            Console.Write("\b \b");
        //            timeLeft--;
        //        }
    }
}
