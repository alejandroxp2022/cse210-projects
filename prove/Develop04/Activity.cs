using System;

abstract class Activity
{
    //fields
    protected string _activityName;
    protected string _description;
    protected int _durationInSeconds;

    public Activity(string activityName, string description, int durationInSeconds )
    {
        _activityName = activityName;
        _description = description;
        _durationInSeconds = durationInSeconds;
    }
    public Activity()
    {
        _activityName = "";
        _description = "";
        _durationInSeconds = 0;

    }
    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        Console.WriteLine("");
        Console.WriteLine($"{_description}");
        Console.WriteLine("");
    }
    public void SetDurationInSeconds()
    {
        Console.Write("How long, in seconds, would you like for your session?: ");
        _durationInSeconds = Convert.ToInt32(Console.Read());
        Console.Clear();

    }
    public void PausingWhileShowingSpinner()
    {
        //Console.WriteLine("Get ready...");
        var symbols = new List<string> {"-","/","-","\\"};
        foreach (var symbol in symbols)
        {
            Console.Write($"{symbol}");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            //Console.Write("-"); // Replace it with the - character
        }
    }
    public void DisplayEndMessage()
    {
        //Console.WriteLine("Well done!!");
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_durationInSeconds} seconds of the {_activityName} Activity");
    }
    public void PausingWhileShowingCountdown()
    {
        var symbols = new List<string> {"5","4","3","2","1"};
        foreach (var symbol in symbols)
        {
            Console.Write($"{symbol}");
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            //Console.Write("-"); // Replace it with the - character
        }
    }
} 