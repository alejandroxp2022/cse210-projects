using System;

    public class Job
    {
        // The C# convention is to start member variables with an underscore _
        public string _company = "";
        public string _jobTitle = "";
        public int _startYear;
        public int _endYear; 

        public Job()
        {
        }

        public void Display()
        {
            Console.WriteLine($"Job Title {_company} {_startYear}-{_endYear}");
        }

    }