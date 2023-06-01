using System;

class MathAssignment: Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment( string studentName, string topic, string textbookSection, string problems) :  base (studentName, topic)
    {
        _studentName = studentName;
        _topic = topic;
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"The Text book Section is {_textbookSection} and the Problems are {_problems}";
    }
}