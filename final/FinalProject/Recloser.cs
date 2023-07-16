using System;

class Recloser: EnergyDevice
{
    //fields
   public float _freq_inverter;
   public float _freq_line;
   public string _operation_mode;
     // Constructors
    public Recloser(string type, string name, string desc, string IPaddress, string modbusParams  ): base (type, name,desc, IPaddress, modbusParams )
     {
        _freq_inverter = 50;
     }
    public Recloser()
     {
        _freq_inverter = 50;
     }
  // POLYMORPHISM
    override public void ExtraParams() 
    {
       // Console.Clear();
        Console.WriteLine("What is the current Frequency from Inverter? [49.1 - 50.9] Hz");
        _freq_inverter = float.Parse(Console.ReadLine());
        Console.WriteLine("What is thecurrent Frequency from Distributor? [49.1 - 50.9] Hz"); 
        _freq_line = float.Parse(Console.ReadLine());
        Console.WriteLine("What is the Operation Mode? [ OPEN, CLOSED]");
        _operation_mode = Console.ReadLine();

    }
} 