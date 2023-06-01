using System;

class Assignment
{
    protected string _studentName;
    protected string _topic;

    public Assignment()
    {
        _studentName = "Unknown";
        _topic = "Unknown";
        
    }
    public Assignment( string studentname, string topic)
    {
        _studentName = studentname;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"The Student Name is {_studentName}, and the topic is {_topic}";
    }
}