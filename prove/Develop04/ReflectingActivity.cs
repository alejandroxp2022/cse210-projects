using System;

class ReflectingActivity: Activity
{
    public string _prompt;
    public string _question_prompt;
    public ReflectingActivity()
    {
        _description = @"This activity will help you reflect on times in your life when you have shown strength and resilience. 
This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _activityName = "Reflecting";
        _durationInSeconds = Convert.ToInt32(0);
    }
    public void SetRandomPrompt()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");
        Random rand = new Random();
        _prompt = prompts[rand.Next(prompts.Count())];
       // return _prompt;
    }
    public void SetRandomQuestionPrompt()
    {
        List<string> qprompts = new List<string>();
        qprompts.Add("Why was this experience meaningful to you?");
        qprompts.Add("Have you ever done anything like this before?");
        qprompts.Add("How did you get started?");
        qprompts.Add("How did you feel when it was complete?");
        qprompts.Add("What made this time different than other times when you were not as successful?");
        qprompts.Add("What is your favorite thing about this experience?");
        qprompts.Add("What could you learn from this experience that applies to other situations?");
        qprompts.Add("What did you learn about yourself through this experience?");
        qprompts.Add("How can you keep this experience in mind in the future?");
        Random qrand = new Random();
        _question_prompt = qprompts[qrand.Next(qprompts.Count())];
        //return _question_prompt;
    }

    public void RunActivity()
    {
        int duration = 0; 
        DisplayStartMessage();
        SetDurationInSeconds();
        Console.WriteLine("Get ready...");
        PausingWhileShowingSpinner();
        if (_durationInSeconds > 0)
        {
            do {
           //     Console.WriteLine($"{_durationInSeconds} ** {duration}");
                Console.WriteLine("");
                SetRandomPrompt();
                Console.Write($"{_prompt} ");
                PausingWhileShowingCountdown();
                Console.WriteLine("");
                SetRandomQuestionPrompt();
                Console.Write($"{_question_prompt} ");
                PausingWhileShowingCountdown();
                Console.WriteLine("");
            // Thread.Sleep(1000);
                duration += 10;
            }
            while (duration <= _durationInSeconds);
        
             //Console.WriteLine("");
            Console.WriteLine("Well done!");
            Console.WriteLine("");
        }
        PausingWhileShowingSpinner();
        DisplayEndMessage();
        PausingWhileShowingSpinner();
        Console.WriteLine("");
    }
}