using System;

abstract class Inverter: EnergyTransformer
{
    //fields
    //protected List<Entity> _entitys;
   // protected List<Entity> Entitys { get { return _entitys; } set => _entitys = value; }
    protected string _entityType;
    protected string _entityName;
    protected string _entityDesc;
    protected int _entityPoints;
    protected int _entityTimes;
    protected int _entityCount;
    //protected int _totalPoints;
     public string getName() { return _entityName; }
     public string getType() { return _entityType; }
     public string getDesc() { return _entityDesc; }
     public int getPoints() { return _entityPoints; }
     public int getTimes() { return _entityTimes; }
     public int getCount() { return _entityCount; }
    public Inverter(string entityType, string entityName, string entityDesc, int entityPoints )
     {
        _entityType = entityType;
        _entityName = entityName;
        _entityDesc = entityDesc;
        _entityPoints = entityPoints;
        _entityTimes = 1;
        _entityCount = 0;
        //_totalPoints = entityPoints;
     }
    public Inverter()
     {
        _entityType = "";
        _entityName = "";
        _entityDesc = "";
        _entityPoints = 0;
        _entityTimes = 1;
        _entityCount = 0;
     }

// //    public void AddEntry(Entity entry)
//     {
//         Entitys.Add(entry);
//     }
    virtual public void CreateEntity()
    {
       // Console.Clear();
        Console.WriteLine("What is the name of your entity?");
        _entityName = Console.ReadLine();
        Console.WriteLine("What is a short despcription of it?");
        _entityDesc = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this entity?");
        _entityPoints = Convert.ToInt16(Console.ReadLine());

    }
} 