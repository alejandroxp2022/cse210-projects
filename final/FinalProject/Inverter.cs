using System;

class Inverter: EnergyDevice
{
    
    public int _target_power;
    public Inverter(string type, string name, string desc, string status, string IPaddress, string modbusParams, int targ_pow ): base (type, name,desc, status,IPaddress, modbusParams )
     {
        _target_power = targ_pow;
        _type = "inverter";
     }
    public Inverter()
     {
        _target_power = 0;
        _type = "inverter";
     }

   override public void ExtraParams()
    {
        Console.WriteLine("What is the Target Power to Generate? kW");
        _target_power = int.Parse(Console.ReadLine());
    }
} 