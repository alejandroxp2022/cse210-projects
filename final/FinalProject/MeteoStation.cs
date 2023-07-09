using System;

class MeteoStation
{
    //fields
    protected string _meteoStationType;
    protected string _meteoStationName;
    protected string _meteoStationDesc;
    protected int _meteoStationPoints;
    protected int _meteoStationTimes;
    protected int _meteoStationCount;
    //protected int _totalPoints;
     public string getName() { return _meteoStationName; }
     public string getType() { return _meteoStationType; }
     public string getDesc() { return _meteoStationDesc; }
     public int getPoints() { return _meteoStationPoints; }
     public int getTimes() { return _meteoStationTimes; }
     public int getCount() { return _meteoStationCount; }
    public MeteoStation(string meteoStationType, string meteoStationName, string meteoStationDesc, int meteoStationPoints )
     {
        _meteoStationType = meteoStationType;
        _meteoStationName = meteoStationName;
        _meteoStationDesc = meteoStationDesc;
        _meteoStationPoints = meteoStationPoints;
        _meteoStationTimes = 1;
        _meteoStationCount = 0;
        //_totalPoints = meteoStationPoints;
     }
    public MeteoStation()
     {
        _meteoStationType = "";
        _meteoStationName = "";
        _meteoStationDesc = "";
        _meteoStationPoints = 0;
        _meteoStationTimes = 1;
        _meteoStationCount = 0;
     }

// //    public void AddEntry(MeteoStation entry)
//     {
//         MeteoStations.Add(entry);
//     }
    virtual public void CreateMeteoStation()
    {
       // Console.Clear();
        Console.WriteLine("What is the name of your meteoStation?");
        _meteoStationName = Console.ReadLine();
        Console.WriteLine("What is a short despcription of it?");
        _meteoStationDesc = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this meteoStation?");
        _meteoStationPoints = Convert.ToInt16(Console.ReadLine());

    }
} 