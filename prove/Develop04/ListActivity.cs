using System;

class ListActivity: Activity
{
    public string _prompt;
    List<string> _activities_list = new List<string>();
    public ListActivity()
    {
        _description = @"This activity will help you reflect on good things in your
life by having you list as many things as you can in a certain area";
        _activityName = "Listing";
        _durationInSeconds = Convert.ToInt32(0);

    }
    public void SetRandomPrompt()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");
        Random rand = new Random();
        _prompt = prompts[rand.Next(prompts.Count())];
       // return _prompt;
    }

    public void RunActivity()
    {
        int duration = 0; 
        DisplayStartMessage();
        SetDurationInSeconds();
        Console.WriteLine("Get ready...");
        PausingWhileShowingSpinner();
        Console.WriteLine("");
        SetRandomPrompt();
        Console.WriteLine("List as many responses you can to the following prompot:");
        Console.WriteLine($" --- {_prompt} --- ");
        Console.Write("You may begin in:");
        PausingWhileShowingCountdown();
        Console.WriteLine("");
              
        if (_durationInSeconds > 0)
        {
            do {
                var watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                Console.Write("> ");
                string input = Console.ReadLine();
                _activities_list.Add(input.ToString());
                watch.Stop();

                duration += Convert.ToInt32(watch.ElapsedMilliseconds.ToString()) / 1000;
            }
            while (duration <= _durationInSeconds);
        
            Console.WriteLine("");
            Console.WriteLine($"You listed {_activities_list.Count()} items!");
            Console.WriteLine("");
        }
        PausingWhileShowingSpinner();
        DisplayEndMessage();
        PausingWhileShowingSpinner();
        Console.WriteLine("");
    }
}