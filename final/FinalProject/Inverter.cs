using System;

class Inverter: EnergyDevice
{
    //fields
    //protected List<Entity> _s;
   // protected List<Entity> Entitys { get { return _s; } set => _s = value; }
     public int getTimes() { return _Times; }
     public int getCount() { return _Count; }
    public Inverter(string type, string Name, string Desc, int Points )
     {
        _Type = Type;
        _Name = Name;
        _Desc = Desc;
        _Points = Points;
        _Times = 1;
        _Count = 0;
        //_totalPoints = Points;
     }
    public Inverter()
     {
        _Type = "";
        _Name = "";
        _Desc = "";
        _Points = 0;
        _Times = 1;
        _Count = 0;
     }

// //    public void AddEntry(Entity entry)
//     {
//         Entitys.Add(entry);
//     }
   override public void CreateEnergyTransformer()
    {
       // Console.Clear();
        Console.WriteLine("What is the name of your ?");
        _Name = Console.ReadLine();
        Console.WriteLine("What is a short despcription of it?");
        _Desc = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this ?");
        _Points = Convert.ToInt16(Console.ReadLine());

    }
} 