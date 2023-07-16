using System;

// INHERITANCE
class Tracker: EnergyDevice
{
   public float _target_position; 
   public float _current_position; 

   public string _operation_mode;
    public Tracker(string type, string name, string desc, string IPaddress, string modbusParams  ): base (type, name,desc, IPaddress, modbusParams )
     {
        _target_position = 0;
        _current_position = 0;
        _operation_mode = "AUTO";
     }
    public Tracker()
     {
     }

   // POLYMORPHISM
    override public void ExtraParams() 
    {
       // Console.Clear();
        Console.WriteLine("What is the current Position? [-60, 60] degrees");
        _current_position = float.Parse(Console.ReadLine());
        Console.WriteLine("What is the target Position? [-60, 60] degrees");
        _target_position = float.Parse(Console.ReadLine());
        Console.WriteLine("What is the Operation Mode? [AUTO, MANUAL, SECURITY]");
        _operation_mode = Console.ReadLine();

    }
} 