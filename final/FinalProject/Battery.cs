using System;

class Battery: EnergyDevice
{
    //fields
   public int _stored_power;
     // Constructors
    public Battery(string type, string name, string desc,string status,  string IPaddress, string modbusParams, int stor_pow ): base (type, name,desc, status, IPaddress, modbusParams )
     {
        _stored_power = stor_pow;
        _type = "battery";
     }
    public Battery()
     {
        _stored_power = 0;
        _type = "battery";
     }

    override public void ExtraParams()
    {
       // Console.Clear();
        Console.WriteLine("What is the current Power Stored? kW");
        _stored_power = int.Parse(Console.ReadLine());
    }
} 