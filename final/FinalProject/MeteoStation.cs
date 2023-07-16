using System;

class MeteoStation: EnergyDevice
{
    //fields
    public float _temperature;
    public MeteoStation(string type, string name, string desc, string IPaddress, string modbusParams, float temp ): base (type, name,desc, IPaddress, modbusParams )
     {
      _temperature = temp;
     }
    public MeteoStation()
     {
         _temperature = 0;
     }

    override public void ExtraParams()
    {
        Console.WriteLine("What is the current temperature? Celcius");
        _temperature = float.Parse(Console.ReadLine());
    }
} 