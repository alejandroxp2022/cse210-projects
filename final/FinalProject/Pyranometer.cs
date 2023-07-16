using System;

class Pyranometer: EnergyDevice
{
    //fields
    public int _radiation;

     // Constructors
    public Pyranometer(string type, string name, string desc, string IPaddress, string modbusParams, int radiation ): base (type, name,desc, IPaddress, modbusParams )
     {
        _radiation = radiation;
     }
    public Pyranometer()
     {
        _radiation = 0;
     }

    override public void ExtraParams()
    {
        Console.WriteLine("What is the current Sun radiation? W/m2");
        _radiation = int.Parse(Console.ReadLine());
    }
} 