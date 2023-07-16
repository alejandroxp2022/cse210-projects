using System;

// ABSTRACTION
abstract class EnergyDevice
{
    //ENCAPSULATION
    protected string _name;
    protected string _status;
    protected string _description;
    protected string _type;
    protected string _voltage_curr;
    protected float _power_nom;
    protected int _current_curr;
    protected string _IPaddress;
    protected string _modbusParams;
    public string getName() { return _name; }
    public string getType() { return _type; }
    public string getDesc() { return _description; }
    public int getcurrCurr() { return _current_curr; }
    public float getPowerNom() { return _power_nom; }

     // Constructors
    public EnergyDevice(string type, string name, string desc, string IPaddress, string modbusParams )
     {
        _type = type;
        _name = name;
        _description = desc;
        _IPaddress = IPaddress;
        _modbusParams = modbusParams;
     }
    public EnergyDevice()
     {
        _type = "";
        _name = "";
        _description = "";
        _IPaddress = "";
        _modbusParams = "";
     }

   public virtual string getAttributeFromString( string StreamValues, string Parser)
   {
      return StreamValues;
   }
   public virtual void setOperation( string StreamConnection, string Parser, string Value)
   {
      ;
   }
   public virtual void setValue( string StreamConnection, string Parser, string Value)
   {
      ;
   }
   public virtual void setStatus( string StreamConnection, string Parser, string Value)
   {
      ;
   }
   public string getStatus( string StreamConnection, string deviceId )
   {
      return _status; 
   }

   // INHERITANCE AND POLYMOFPHISM
   public void CreateDevice()
   {
        Console.WriteLine("What is the name of your ?");
        _name = Console.ReadLine();
        Console.WriteLine("What is a short despcription of it?");
        _description = Console.ReadLine();
        Console.WriteLine("What is the IP address");
        _IPaddress = Console.ReadLine();
        Console.WriteLine("What is the current Status? ON/OFF");
        _status = Console.ReadLine();
        this.ExtraParams();

   }
   virtual public void ExtraParams()
   {}
} 