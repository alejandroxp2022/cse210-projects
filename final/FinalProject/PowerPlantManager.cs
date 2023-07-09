using System;

class PowerPlantManager
{
    //fields
    protected List<EnergyGenerator> EnergyGenerators = new List<EnergyGenerator>();
    protected List<EnergyTransformer> EnergyTransformers = new List<EnergyTransformer>();
    protected List<EnergyTransmit> EnergyTransmits = new List<EnergyTransmit>();
    protected List<EnergyStore> EnergyStores = new List<EnergyStore>();
    protected string _filename;
    private string _separator = "|";
    public int _totalPoints;
    public int _pointsEarned;
    public void CreatePowerPlant()
    {
        string _tecla2;
        Console.WriteLine("The types of Energy Entity are:");
                    Console.WriteLine("     1. Tracker");
                    Console.WriteLine("     2. Solar Panel");
                    Console.WriteLine("     3. Inverter");
                    Console.WriteLine("     4. Battery");
                    Console.WriteLine("     5. Recloser");
                    Console.WriteLine("     6. Wind Station");
                    Console.WriteLine("     7. Pyranometer");
                    Console.WriteLine("     8. DustIQ");
                    Console.WriteLine("Which type of device would you like to create?");
                    _tecla2  = Console.ReadLine();
                    switch (_tecla2)
                    {
                        case "1":
                            Tracker tracker = new Tracker();
                            tracker.CreateEntityGenerator();
                            EnergyGenerators.Add(tracker);
                            break;
                        case "2":
                            SolarPanel solarPanel = new SolarPanel();
                            solarPanel.CreateEntityGenerator();
                            EnergyGenerators.Add(solarPanel);
                            break;
                        case "3":
                            Inverter inveter1 = new Inverter();
                            inveter1.CreateEnergyTransformer();
                            EnergyTransformers.Add(inveter1);
                            break;
                        case "4":
                            Battery battery1 = new Battery();
                            battery1.CreateEnergyStore();
                            EnergyStores.Add(battery1);
                            break;
                        default:
                            Console.WriteLine("Please select the right option.");
                        break;
                    }
    }
   public void ListNames()
    {
        Console.WriteLine("The entitys are:");
        int counter = 0 ;
        int internal_counter = -1 ;
        foreach ( EnergyGenerator entity in EnergyGenerators)
        {
            if(entity != null)
            {
                counter++;
                internal_counter++;
                string value = $"{counter.ToString()}.- {entity.getName()}";
                Console.WriteLine(value);
            //    GoalNames.Add($"{counter.ToString()}|{internal_counter.ToString()}|EnergyGenerator|{entity.getName()} ");
            }
        }
        internal_counter = -1 ;
        foreach ( EnergyTransformer entity in EnergyTransformers)
        {
            if(entity != null)
            {
            counter++;
            internal_counter++;
            Console.WriteLine($"{counter.ToString()}.- {entity.getName()}");
         //   GoalNames.Add($"{counter.ToString()}|{internal_counter.ToString()}|EnergyTransformer|{entity.getName()}");
            }
        }
        internal_counter = -1 ;
        foreach ( EnergyTransmit entity in EnergyTransmits)
        {
            if(entity != null)
            {
            counter++;
            internal_counter++;
            Console.WriteLine($"{counter.ToString()}.- {entity.getName()}");
        //    GoalNames.Add($"{counter.ToString()}|{internal_counter.ToString()}|EnergyTransmit|{entity.getName()}");
            }
        }
    }
    public void ListAllGoals()
    {
        Console.WriteLine("The entitys are:");
        int counter = 0 ;
        foreach ( EnergyGenerator entity in EnergyGenerators)
        {
            counter++;
                string _checkS = " ";
              //  if (entity.getStatus() == true) {
              //      _checkS = "X";
               // }
                
                Console.WriteLine($"{counter}.- [{_checkS}] {entity.getName()} ({entity.getDesc()})");
        }
        foreach ( EnergyTransformer entity in EnergyTransformers)
        {
                 string _checkE = " ";
            counter++;
            Console.WriteLine($"{counter}.- [{_checkE}] {entity.getName()} ({entity.getDesc()})");
        }
        foreach ( EnergyTransmit entity in EnergyTransmits)
        {
                  string _checkC = " ";
             //   if (entity.getStatus() == true) {
               //     _checkC = "X";
              //  }
           counter++;
            Console.WriteLine($"{counter}.- [{_checkC}] {entity.getName()} ({entity.getDesc()})  -- Currently completed: {entity.getName()}/{entity.getName()}");
        }
    }
    public void SaveAllGoals()
    {
        Console.WriteLine("What is the filename for the entity file?");
        _filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            //total points first
            outputFile.WriteLine($"{_totalPoints}");
            //now the entitys by type
            foreach (EnergyGenerator entry in EnergyGenerators)
            {
                outputFile.WriteLine($"EnergyGenerator{_separator}{entry.getName()}{_separator}{entry.getDesc()}{_separator}{_separator}{entry.getName()}");
            }
            foreach (EnergyTransformer entry in EnergyTransformers)
            {
                outputFile.WriteLine($"EnergyTransformer{_separator}{entry.getName()}{_separator}{entry.getDesc()}{_separator}{entry.getName()}");
            }
            foreach (EnergyTransmit entry in EnergyTransmits)
            {
                outputFile.WriteLine($"EnergyTransmit{_separator}{entry.getName()}{_separator}{entry.getDesc()}{_separator}{entry.getName()}{_separator}{entry.getName()}{_separator}{entry.getName()}{_separator}{entry.getName()}");
            }
          
        }
    }
    public void LoadGoals()
 {
        // To not load entries repeatedly 
        Console.WriteLine("What is the filename for the entity file?");
        _filename = Console.ReadLine();
        using (StreamReader inputFile = new StreamReader(_filename))
        {
            _totalPoints = Convert.ToInt16(inputFile.ReadLine());
            while (!inputFile.EndOfStream)
            {
                string line = inputFile.ReadLine();
                string[] parts = line.Split(new[] { "|" }, StringSplitOptions.None);
                //string prompt = parts[1].Split(':')[0].Trim();
                if ( parts[0] == "Battery")
                {
                    //EnergyGenerator _energyGenerator = new EnergyGenerator(parts[0],parts[1],parts[2],Convert.ToInt16(parts[3]),Convert.ToBoolean(parts[4].Trim()));
                    Battery _battery = new Battery();
                    EnergyStores.Add(_battery);

                }
                if ( parts[0] == "Tracker")
                {
                    //EnergyTransformer _energyTransformer = new EnergyTransformer(parts[0],parts[1],parts[2],Convert.ToInt16(parts[3].Trim()));
                    Tracker _tracker = new Tracker();
                    EnergyGenerators.Add(_tracker);
                }
                if ( parts[0] == "Inverter")
                {
                    //Inverter _inverter = new Inverter(parts[0],parts[1],parts[2],Convert.ToInt16(parts[3]),Convert.ToInt16(parts[4]),Convert.ToInt16(parts[5]),Convert.ToInt16(parts[6].Trim()));   
                    Inverter _inverter = new Inverter();
                    EnergyTransformers.Add(_inverter);

                }
                    
            }
        }
    }
    // public void RecordEvent()
    // {
    //     ListNames();
    //     Console.WriteLine("");
    //     Console.WriteLine("Which entity did you accomplish?");
    //     string _orderEvent = Console.ReadLine();
    //     foreach ( string _entityName in GoalNames)
    //     {
    //          string[] parts = _entityName.Split(new[] { "|" }, StringSplitOptions.None);
    //          //verifying count
    //          if (_orderEvent == parts[0])
    //          {
    //             // getting type of event
    //             if( parts[2] == "EnergyGenerator")
    //             {
    //                 _pointsEarned = EnergyGenerators[Convert.ToInt16(parts[1])].getName(); 
    //                EnergyGenerators[Convert.ToInt16(parts[1])].setChecked();
                    
    //             }
    //             if( parts[2] == "EnergyTransformer")
    //             {
    //                 _pointsEarned = EnergyTransformers[Convert.ToInt16(parts[1])].getName(); 
    //             }
    //             if( parts[2] == "EnergyTransmit")
    //             {
    //                 _pointsEarned = EnergyTransmits[Convert.ToInt16(parts[1])].getName(); 
    //                 int _entityTimes =EnergyTransmits[Convert.ToInt16(parts[1])].getTimes();  
    //                 int _entityCount =EnergyTransmits[Convert.ToInt16(parts[1])].getCount();  
    //                 _entityCount++;
    //                 EnergyTransmits[Convert.ToInt16(parts[1])].setCount(_entityCount);   
    //                 EnergyTransmits[Convert.ToInt16(parts[1])].setChecked(_entityTimes, _entityCount);
    //             }
    //          }
    //     }
    //     _totalPoints += _pointsEarned;
    //     Console.WriteLine($"Congratulations! You have earned {_pointsEarned} points!");
    //     Console.WriteLine($"You now have {_totalPoints} points");
    // }
} 