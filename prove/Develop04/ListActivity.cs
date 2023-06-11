using System;

class ListActivity: Activity
{
    public ListActivity()
    {
        _description = @"This activity will help you reflect on good things in your
        life by having you list as many things as you can in a certain area";
        _activityName = "Listing Activity";
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