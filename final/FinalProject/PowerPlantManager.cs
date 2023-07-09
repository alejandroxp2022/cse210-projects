using System;

class PowerPlantManager
{
    //fields
    protected List<EnergyGenerator> EnergyGenerators = new List<EnergyGenerator>();
    protected List<EnergyTransformer> EnergyTransformers = new List<EnergyTransformer>();
    protected List<EnergyTransmit> EnergyTransmits = new List<EnergyTransmit>();
    protected List<string> GoalNames = new List<string>();
    protected string _filename;
    private string _separator = "|";
    public int _totalPoints;
    public int _pointsEarned;
    public void CreatePowerPlant()
    {
        string _tecla2;
        Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("     1. Simple Goal");
                    Console.WriteLine("     2. Eternal Goal");
                    Console.WriteLine("     3. Checklist Goal");
                    Console.WriteLine("     4. Negative Events");
                    Console.WriteLine("Which type of goal would you like to create?");
                    _tecla2  = Console.ReadLine();
                    switch (_tecla2)
                    {
                        case "1":
                            EnergyGenerator energyGenerator = new EnergyGenerator();
                            energyGenerator.CreateEntity();
                            EnergyGenerators.Add(energyGenerator);
                            break;
                        case "2":
                            EnergyTransformer energyTransformer = new EnergyTransformer();
                            energyTransformer.CreateEntity();
                            EnergyTransformers.Add(energyTransformer);
                            break;
                        case "3":
                            EnergyTransmit energyTransmit = new EnergyTransmit();
                            energyTransmit.CreateEntity();
                            EnergyTransmits.Add(energyTransmit);
                            break;
                        case "4":
                            EnergyGenerator negativeEvent = new EnergyGenerator();
                            negativeEvent.CreateEntity();
                            negativeEvent.setPoints(negativeEvent.getPoints()*-1);
                            EnergyGenerators.Add(negativeEvent);
                            break;
                        default:
                            Console.WriteLine("Please select the right option.");
                        break;
                    }
    }
   public void ListNames()
    {
        Console.WriteLine("The goals are:");
        int counter = 0 ;
        int internal_counter = -1 ;
        foreach ( EnergyGenerator goal in EnergyGenerators)
        {
            if(goal != null)
            {
                counter++;
                internal_counter++;
                string value = $"{counter.ToString()}.- {goal.getName()}";
                Console.WriteLine(value);
                GoalNames.Add($"{counter.ToString()}|{internal_counter.ToString()}|EnergyGenerator|{goal.getName()} ");
            }
        }
        internal_counter = -1 ;
        foreach ( EnergyTransformer goal in EnergyTransformers)
        {
            if(goal != null)
            {
            counter++;
            internal_counter++;
            Console.WriteLine($"{counter.ToString()}.- {goal.getName()}");
            GoalNames.Add($"{counter.ToString()}|{internal_counter.ToString()}|EnergyTransformer|{goal.getName()}");
            }
        }
        internal_counter = -1 ;
        foreach ( EnergyTransmit goal in EnergyTransmits)
        {
            if(goal != null)
            {
            counter++;
            internal_counter++;
            Console.WriteLine($"{counter.ToString()}.- {goal.getName()}");
            GoalNames.Add($"{counter.ToString()}|{internal_counter.ToString()}|EnergyTransmit|{goal.getName()}");
            }
        }
    }
    public void ListAllGoals()
    {
        Console.WriteLine("The goals are:");
        int counter = 0 ;
        foreach ( EnergyGenerator goal in EnergyGenerators)
        {
            counter++;
                string _checkS = " ";
              //  if (goal.getStatus() == true) {
              //      _checkS = "X";
               // }
                
                Console.WriteLine($"{counter}.- [{_checkS}] {goal.getName()} ({goal.getDesc()})");
        }
        foreach ( EnergyTransformer goal in EnergyTransformers)
        {
                 string _checkE = " ";
            counter++;
            Console.WriteLine($"{counter}.- [{_checkE}] {goal.getName()} ({goal.getDesc()})");
        }
        foreach ( EnergyTransmit goal in EnergyTransmits)
        {
                  string _checkC = " ";
             //   if (goal.getStatus() == true) {
               //     _checkC = "X";
              //  }
           counter++;
            Console.WriteLine($"{counter}.- [{_checkC}] {goal.getName()} ({goal.getDesc()})  -- Currently completed: {goal.getCount()}/{goal.getTimes()}");
        }
    }
    public void SaveAllGoals()
    {
        Console.WriteLine("What is the filename for the goal file?");
        _filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            //total points first
            outputFile.WriteLine($"{_totalPoints}");
            //now the goals by type
            foreach (EnergyGenerator entry in EnergyGenerators)
            {
                outputFile.WriteLine($"EnergyGenerator{_separator}{entry.getName()}{_separator}{entry.getDesc()}{_separator}{entry.getPoints()}{_separator}{entry.getStatus()}");
            }
            foreach (EnergyTransformer entry in EnergyTransformers)
            {
                outputFile.WriteLine($"EnergyTransformer{_separator}{entry.getName()}{_separator}{entry.getDesc()}{_separator}{entry.getPoints()}");
            }
            foreach (EnergyTransmit entry in EnergyTransmits)
            {
                outputFile.WriteLine($"EnergyTransmit{_separator}{entry.getName()}{_separator}{entry.getDesc()}{_separator}{entry.getPoints()}{_separator}{entry.getBonus()}{_separator}{entry.getTimes()}{_separator}{entry.getCount()}");
            }
          
        }
    }
    public void LoadGoals()
 {
        // To not load entries repeatedly 
        Console.WriteLine("What is the filename for the goal file?");
        _filename = Console.ReadLine();
        using (StreamReader inputFile = new StreamReader(_filename))
        {
            _totalPoints = Convert.ToInt16(inputFile.ReadLine());
            while (!inputFile.EndOfStream)
            {
                string line = inputFile.ReadLine();
                string[] parts = line.Split(new[] { "|" }, StringSplitOptions.None);
                //string prompt = parts[1].Split(':')[0].Trim();
                if ( parts[0] == "EnergyGenerator")
                {
                    EnergyGenerator _energyGenerator = new EnergyGenerator(parts[0],parts[1],parts[2],Convert.ToInt16(parts[3]),Convert.ToBoolean(parts[4].Trim()));
                    EnergyGenerators.Add(_energyGenerator);

                }
                if ( parts[0] == "EnergyTransformer")
                {
                    EnergyTransformer _energyTransformer = new EnergyTransformer(parts[0],parts[1],parts[2],Convert.ToInt16(parts[3].Trim()));
                    EnergyTransformers.Add(_energyTransformer);
                }
                if ( parts[0] == "EnergyTransmit")
                {
                    EnergyTransmit _energyTransmit = new EnergyTransmit(parts[0],parts[1],parts[2],Convert.ToInt16(parts[3]),Convert.ToInt16(parts[4]),Convert.ToInt16(parts[5]),Convert.ToInt16(parts[6].Trim()));   
                    EnergyTransmits.Add(_energyTransmit);

                }
                    
            }
        }
    }
    public void RecordEvent()
    {
        ListNames();
        Console.WriteLine("");
        Console.WriteLine("Which goal did you accomplish?");
        string _orderEvent = Console.ReadLine();
        foreach ( string _goalName in GoalNames)
        {
             string[] parts = _goalName.Split(new[] { "|" }, StringSplitOptions.None);
             //verifying count
             if (_orderEvent == parts[0])
             {
                // getting type of event
                if( parts[2] == "EnergyGenerator")
                {
                    _pointsEarned = EnergyGenerators[Convert.ToInt16(parts[1])].getPoints(); 
                   EnergyGenerators[Convert.ToInt16(parts[1])].setChecked();
                    
                }
                if( parts[2] == "EnergyTransformer")
                {
                    _pointsEarned = EnergyTransformers[Convert.ToInt16(parts[1])].getPoints(); 
                }
                if( parts[2] == "EnergyTransmit")
                {
                    _pointsEarned = EnergyTransmits[Convert.ToInt16(parts[1])].getPoints(); 
                    int _goalTimes =EnergyTransmits[Convert.ToInt16(parts[1])].getTimes();  
                    int _goalCount =EnergyTransmits[Convert.ToInt16(parts[1])].getCount();  
                    _goalCount++;
                    EnergyTransmits[Convert.ToInt16(parts[1])].setCount(_goalCount);   
                    EnergyTransmits[Convert.ToInt16(parts[1])].setChecked(_goalTimes, _goalCount);
                }
             }
        }
        _totalPoints += _pointsEarned;
        Console.WriteLine($"Congratulations! You have earned {_pointsEarned} points!");
        Console.WriteLine($"You now have {_totalPoints} points");
    }
} 