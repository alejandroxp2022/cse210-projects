using System;

class MeteoStation: EnergyDevice
{
    //fields
    public float _temperature;
    public float _wind_speed;
    public MeteoStation(string type, string name, string desc, string IPaddress, string modbusParams, float temp, float wind_sp ): base (type, name,desc, IPaddress, modbusParams )
     {
      _temperature = temp;
      _wind_speed = wind_sp;
      _type = "meteoStation";
     }
    public MeteoStation()
     {
      _temperature = 0;
      _type = "meteoStation";
     }

    override public void ExtraParams()
    {
        Console.WriteLine("What is the current Temperature? Celcius");
        _temperature = float.Parse(Console.ReadLine());
        Console.WriteLine("What is the current Wind Speed? m/s");
        _wind_speed = float.Parse(Console.ReadLine());
    }
} 