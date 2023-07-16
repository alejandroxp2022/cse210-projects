using System;

class Tracker: EnergyDevice
{
    //fields
    //protected List<Tracker> _trackers;
   // protected List<Tracker> Trackers { get { return _trackers; } set => _trackers = value; }
    protected string _trackerType;
    protected string _trackerName;
    protected string _trackerDesc;
    protected int _trackerPoints;
    protected int _trackerTimes;
    protected int _trackerCount;
    //protected int _totalPoints;
     public string getName() { return _trackerName; }
     public string getType() { return _trackerType; }
     public string getDesc() { return _trackerDesc; }
     public int getPoints() { return _trackerPoints; }
     public int getTimes() { return _trackerTimes; }
     public int getCount() { return _trackerCount; }
    public Tracker(string trackerType, string trackerName, string trackerDesc, int trackerPoints )
     {
        _trackerType = trackerType;
        _trackerName = trackerName;
        _trackerDesc = trackerDesc;
        _trackerPoints = trackerPoints;
        _trackerTimes = 1;
        _trackerCount = 0;
        //_totalPoints = trackerPoints;
     }
    public Tracker()
     {
        _trackerType = "";
        _trackerName = "";
        _trackerDesc = "";
        _trackerPoints = 0;
        _trackerTimes = 1;
        _trackerCount = 0;
     }

// //    public void AddEntry(Tracker entry)
//     {
//         Trackers.Add(entry);
//     }
    override public void CreateEntityGenerator()
    {
       // Console.Clear();
        Console.WriteLine("What is the name of your tracker?");
        _trackerName = Console.ReadLine();
        Console.WriteLine("What is a short despcription of it?");
        _trackerDesc = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this tracker?");
        _trackerPoints = Convert.ToInt16(Console.ReadLine());

    }
} 