using System;

abstract class MeteoDevice
{
    //fields
    protected string _deviceName;
    protected string _deviceStatus;
    protected string _deviceDescription;
    protected string _deviceType;
    protected string _voltage_curr;
    protected float _power_nom;
    protected int _current_curr;
    protected string _IPaddress;
    protected string _ModbusParams;
     public string getName() { return _deviceName; }
     public string getType() { return _deviceType; }
     public string getDesc() { return _deviceDescription; }
     public int getcurrCurr() { return _current_curr; }
     public float getPowerNom() { return _power_nom; }

     // Constructors
    public MeteoEntity(string deviceType, string deviceName, string deviceDesc, string IPaddress, string ModbusParams )
     {
        _deviceType = deviceType;
        _deviceName = deviceName;
        _deviceDescription = deviceDesc;
        _IPaddress = IPaddress;
        _ModbusParams = ModbusParams;
     }
    public MeteoEntity()
     {
        _deviceType = "";
        _deviceName = "";
        _deviceDescription = "";
        _IPaddress = "";
        _ModbusParams = "";
     }

   public string getAttributeFromString( string StreamValues, string Parser)
   {
      return StreamValues;
   }
   public void setOperation( string StreamConnection, string Parser, string Value)
   {
      ;
   }
   public void setValue( string StreamConnection, string Parser, string Value)
   {
      ;
   }
   public void setStatus( string StreamConnection, string Parser, string Value)
   {
      ;
   }
   public string getStatus( string StreamConnection, string deviceId )
   {
      return _deviceStatus; 
   }
    virtual public void CreateEntity()
    {
       // Console.Clear();
        Console.WriteLine("What is the name of your device?");
        _deviceName = Console.ReadLine();
        Console.WriteLine("What is a short despcription of it?");
        _deviceDescription = Console.ReadLine();
        Console.WriteLine("What is the IP address");
        _IPaddress = Console.ReadLine();

    }
} 