using System;

class BreathingActivity: Activity
{

    public BreathingActivity()
    {
        _description = @"This activity will help you relax by walking your through breathing in and out slowly.
Clear your mind and focus on your breathing.";
        _activityName = "Breathing";
        //_durationInSeconds = 0;
    }
    public void RunActivity()
    {
        int duration = 0; 
        DisplayStartMessage();
        SetDurationInSeconds();
        Console.WriteLine("Get ready...");
        PausingWhileShowingSpinner();
        do {
           // Console.WriteLine($"{_durationInSeconds} ** {duration}");
            Console.WriteLine("");
            Console.Write("Breath in...");
            PausingWhileShowingCountdown();
            Console.WriteLine("");
            Console.Write("Now breath out...");
            PausingWhileShowingCountdown();
            Console.WriteLine("");
           // Thread.Sleep(1000);
            duration += 10;
        }
        while (duration <= _durationInSeconds);
        //Console.WriteLine("");
        Console.WriteLine("Well done!");
        Console.WriteLine("");
        PausingWhileShowingSpinner();
        DisplayEndMessage();
        PausingWhileShowingSpinner();
        Console.WriteLine("");
    }
}