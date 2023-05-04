using System;

     public class Resume
    {
        // The C# convention is to start member variables with an underscore _
        public string _name = "";
        public List<Job> _jobs = new List<Job>();
        public Resume()
        {
        }

        public void Display()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Jobs: ");
            foreach (Job job in _jobs)
            {
                job.Display();
            }
        }

    }