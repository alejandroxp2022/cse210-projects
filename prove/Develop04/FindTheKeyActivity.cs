using System;

class FindTheKeywordActivity: Activity
{
    public int _counts = 0;
    public char _keyword;
    List<string> _activities_list = new List<string>();
    public FindTheKeywordActivity()
    {
        _description = @"This activity will help you practice to find the keywords as soon as you can, 
remember to practice Breathing Activity after this one :)";
        _activityName = "FindTheKeyword";
        _durationInSeconds = Convert.ToInt32(0);

    }
    public void SetRandomKeyword()
    {
        //List<char> keywords = new List<char>();
        string keywords = "abcdefghijklmnopqrstuvwxy";
        Random rand = new Random();
        _keyword = keywords[rand.Next(keywords.Count())];
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
        //Console.Write("You may begin in:");
        //PausingWhileShowingCountdown();
        //Console.WriteLine("");
              
        if (_durationInSeconds > 0)
        {
            do {
                SetRandomKeyword();
                Console.WriteLine("Type the keyword as fast as you can:");
                Console.WriteLine($" --- {_keyword} --- ");
                var watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                char input;
                do {
                    Console.Write("> ");
                    input = Convert.ToChar(Console.ReadLine());
                    _activities_list.Add(input.ToString());
                } while ( input != _keyword );
                watch.Stop();
                int enlapsedtime = Convert.ToInt32(watch.ElapsedMilliseconds.ToString()) / 1000; 
                Console.WriteLine($"You took {enlapsedtime} seconds.");
                duration += enlapsedtime;
                _counts ++;
            }
            while (duration <= _durationInSeconds);
        
            Console.WriteLine("");
            Console.WriteLine($"You guessed {_counts} keywords!");
            Console.WriteLine("");
        }
        PausingWhileShowingSpinner();
        DisplayEndMessage();
        PausingWhileShowingSpinner();
        Console.WriteLine("");
    }
}