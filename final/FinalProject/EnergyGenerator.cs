using System;

abstract class EnergyGenerator: EnergyEntity
{
    protected string _entityName;
    protected string _entityStatus;
    protected string _entityDescription;
    protected string _entityType;
    protected string _voltage_curr;
    protected float _power_nom;
    protected int _current_curr;
    protected string _IPaddress;
    protected string _ModbusParams;
     public string getName() { return _entityName; }
     public string getType() { return _entityType; }
     public string getDesc() { return _entityDescription; }
     public int getcurrCurr() { return _current_curr; }
     public float getPowerNom() { return _power_nom; }

     // Constructors
    public EnergyGenerator(string entityType, string entityName, string entityDesc, string IPaddress, string ModbusParams )
     {
        _entityType = entityType;
        _entityName = entityName;
        _entityDescription = entityDesc;
        _IPaddress = IPaddress;
        _ModbusParams = ModbusParams;
     }
    public EnergyGenerator()
     {
        _entityType = "";
        _entityName = "";
        _entityDescription = "";
        _IPaddress = "";
        _ModbusParams = "";
     }

   public string getAttributeFromString( string StreamValues, string Parser)
   {
      return StreamValues;
   }
   public void setOperation( string StreamConnection, string Parser, string Value)
   {
      ;
   }
   public void setValue( string StreamConnection, string Parser, string Value)
   {
      ;
   }
   public void setStatus( string StreamConnection, string Parser, string Value)
   {
      ;
   }
   public string getStatus( string StreamConnection, string deviceId )
   {
      return _entityStatus; 
   }
    virtual public void CreateEntityGenerator()
    {
       // Console.Clear();
        Console.WriteLine("What is the name of your entity?");
        _entityName = Console.ReadLine();
        Console.WriteLine("What is a short despcription of it?");
        _entityDescription = Console.ReadLine();
        Console.WriteLine("What is the IP address");
        _IPaddress = Console.ReadLine();

    }
} 