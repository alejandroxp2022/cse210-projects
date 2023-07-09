using System;

abstract class EnergyTransformer: EnergyEntity
{
    //fields
    //protected List<Entity> _entitys;
   // protected List<Entity> Entitys { get { return _entitys; } set => _entitys = value; }
    protected float _powerIn;
    protected float _powerOut;
    protected float _goalPower;
    protected float _frequency;
    protected string _operationStatus;
     public float getPowerIn() { return _powerIn; }
     public float getPowerOut() { return _powerOut; }
     public float getFreq() { return _frequency; }
     public string getOperStatus() { return _operationStatus; }
    public EnergyTransformer(string entityType, string entityName, string entityDesc, int entityPoints )
     {
        _entityType = entityType;
        _entityName = entityName;
        _entityDescription = entityDesc;
     }
    public EnergyTransformer()
     {
        _entityType = "";
        _entityName = "";
     }

    virtual public void CreateEnergyTransformer()
    {
        Console.WriteLine("What is the name of your entity?");
        _entityName = Console.ReadLine();
        Console.WriteLine("What is a short despcription of it?");
        _entityDescription = Console.ReadLine();

    }
} 