using System;

class Recloser: EnergyDevice
{
    //fields
   public float _freq_inverter;
   public float _freq_line;
   public string _operation_mode;
     // Constructors
     // INHERITANCE
    public Recloser(string type, string name, string desc, string IPaddress, string modbusParams, float freq_inv ): base (type, name,desc, IPaddress, modbusParams )
     {
        _freq_inverter = freq_inv;
        _type = "recloser";
     }
    public Recloser()
     {
        _freq_inverter = 50;
        _type = "recloser";
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