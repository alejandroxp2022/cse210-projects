using System;

class ReflectingActivity: Activity
{
    public ReflectingActivity()
    {
        _description = @"This activity will help you reflect on times in your life when you
        have shown strength and resilience. This will help you recognize the power you
        have and how you can use it in other aspects of your life.";
        _activityName = "Reflecting Activity";
    }
    public void RunActivity()
    {
        SetDurationInSeconds();
        int duration = 0; 
        do {
            Console.WriteLine("Breath in...");
            Console.WriteLine("Now breath out...");
            Console.WriteLine("");
            Thread.Sleep(1000);
            duration += 1;
        }
        while (duration < _durationInSeconds);
        Console.WriteLine("Well done!");
    }
}