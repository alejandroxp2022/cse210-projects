using System;

class Battery: EnergyDevice
{
    //fields

     // Constructors
    public Battery(string entityType, string entityName, string entityDesc, string IPaddress, string ModbusParams )
     {
        _entityType = entityType;
        _entityName = entityName;
        _entityDescription = entityDesc;
        _IPaddress = IPaddress;
        _ModbusParams = ModbusParams;
     }
    public Battery()
     {
        _entityType = "";
        _entityName = "";
        _entityDescription = "";
        _IPaddress = "";
        _ModbusParams = "";
     }

    override public void CreateEnergyStore()
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