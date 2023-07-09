using System;

class MonitorPanel
{
    //fields
    protected List<MonitorPanel> MonitorPanels = new List<MonitorPanel>();
    protected List<string> MonitorPanelNames = new List<string>();
    protected string _deviceStatus;
    protected string _deviceName;
    protected string _filename;
    private string _separator = "|";
    public int _totalPoints;
    public int _pointsEarned;
     public string getName() { return _deviceName; }
     public string getStatus() { return _deviceStatus; }
    public void CreateMonitorPanelMenu()
    {
        string _tecla2;
        Console.WriteLine("The types of MonitorPanels are:");
                    Console.WriteLine("     1.  MonitorPanel");
                    Console.WriteLine("     2.  MonitorPanel");
                    Console.WriteLine("     3.  MonitorPanel");
                    Console.WriteLine("     4. Negative Events");
                    Console.WriteLine("Which type of monitor would you like to create?");
                    _tecla2  = Console.ReadLine();
                    switch (_tecla2)
                    {
                        case "1":
                            MonitorPanel simpleMonitorPanel = new MonitorPanel();
                           // simpleMonitorPanel.CreateMonitorPanel();
                            MonitorPanels.Add(simpleMonitorPanel);
                            break;
                        case "2":
                            MonitorPanel eternalMonitorPanel = new MonitorPanel();
                           // eternalMonitorPanel.CreateMonitorPanel();
                            MonitorPanels.Add(eternalMonitorPanel);
                            break;
                        case "3":
                            MonitorPanel checklistMonitorPanel = new MonitorPanel();
                           // checklistMonitorPanel.CreateMonitorPanel();
                            MonitorPanels.Add(checklistMonitorPanel);
                            break;
                        case "4":
                            MonitorPanel negativeEvent = new MonitorPanel();
                            MonitorPanels.Add(negativeEvent);
                            break;
                        default:
                            Console.WriteLine("Please select the right option.");
                        break;
                    }
    }
   public void ListNames()
    {
        Console.WriteLine("The monitors are:");
        int counter = 0 ;
        int internal_counter = -1 ;
        foreach ( MonitorPanel monitor in MonitorPanels)
        {
            if(monitor != null)
            {
                counter++;
                internal_counter++;
                string value = $"{counter.ToString()}.- {monitor.getName()}";
                Console.WriteLine(value);
                MonitorPanelNames.Add($"{counter.ToString()}|{internal_counter.ToString()}|MonitorPanel|{monitor.getName()} ");
            }
        }
        internal_counter = -1 ;
        foreach ( MonitorPanel monitor in MonitorPanels)
        {
            if(monitor != null)
            {
            counter++;
            internal_counter++;
            Console.WriteLine($"{counter.ToString()}.- {monitor.getName()}");
            MonitorPanelNames.Add($"{counter.ToString()}|{internal_counter.ToString()}|MonitorPanel|{monitor.getName()}");
            }
        }
        internal_counter = -1 ;
        foreach ( MonitorPanel monitor in MonitorPanels)
        {
            if(monitor != null)
            {
            counter++;
            internal_counter++;
            Console.WriteLine($"{counter.ToString()}.- {monitor.getName()}");
            MonitorPanelNames.Add($"{counter.ToString()}|{internal_counter.ToString()}|MonitorPanel|{monitor.getName()}");
            }
        }
    }
    public void ListAllMonitorPanels()
    {
        Console.WriteLine("The monitors are:");
        int counter = 0 ;
        foreach ( MonitorPanel monitor in MonitorPanels)
        {
            counter++;
                string _checkS = " ";
                // if (monitor.getStatus() == true) {
                //     _checkS = "X";
                // }
                
                Console.WriteLine($"{counter}.- [{_checkS}] {monitor.getName()} ({monitor.getName()})");
        }
        foreach ( MonitorPanel monitor in MonitorPanels)
        {
                 string _checkE = " ";
            counter++;
            Console.WriteLine($"{counter}.- [{_checkE}] {monitor.getName()} ({monitor.getStatus()})");
        }
        foreach ( MonitorPanel monitor in MonitorPanels)
        {
                  string _checkC = " ";
                // if (monitor.getStatus() == true) {
                //     _checkC = "X";
                // }
           counter++;
            Console.WriteLine($"{counter}.- [{_checkC}] {monitor.getName()} ({monitor.getName()})  -- Currently completed: {monitor.GetType()}/{monitor.getName()}");
        }
    }
    public void SaveAllMonitorPanels()
    {
        Console.WriteLine("What is the filename for the monitor file?");
        _filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            //total points first
            outputFile.WriteLine($"{_totalPoints}");
            //now the monitors by type
            foreach (MonitorPanel entry in MonitorPanels)
            {
                outputFile.WriteLine($"MonitorPanel{_separator}{entry.getName()}{_separator}{entry.getName()}{_separator}{entry.getName()}{_separator}{entry.getStatus()}");
            }
            foreach (MonitorPanel entry in MonitorPanels)
            {
                outputFile.WriteLine($"MonitorPanel{_separator}{entry.getName()}{_separator}{entry.getName()}{_separator}{entry.getName()}");
            }
            foreach (MonitorPanel entry in MonitorPanels)
            {
                outputFile.WriteLine($"MonitorPanel{_separator}{entry.getName()}{_separator}{entry.getName()}{_separator}{entry.getName()}{_separator}{entry.getName()}{_separator}{entry.getName()}{_separator}{entry.getName()}");
            }
          
        }
    }
    public void LoadMonitorPanels()
 {
        // To not load entries repeatedly 
        Console.WriteLine("What is the filename for the monitor file?");
        _filename = Console.ReadLine();
        using (StreamReader inputFile = new StreamReader(_filename))
        {
            _totalPoints = Convert.ToInt16(inputFile.ReadLine());
            while (!inputFile.EndOfStream)
            {
                string line = inputFile.ReadLine();
                string[] parts = line.Split(new[] { "|" }, StringSplitOptions.None);
                //string prompt = parts[1].Split(':')[0].Trim();
                if ( parts[0] == "MonitorPanel")
                {
                    //MonitorPanel _simpleMonitorPanel = new MonitorPanel(parts[0],parts[1],parts[2],Convert.ToInt16(parts[3]),Convert.ToBoolean(parts[4].Trim()));
                    MonitorPanel _simpleMonitorPanel = new MonitorPanel();
                    MonitorPanels.Add(_simpleMonitorPanel);

                }
                if ( parts[0] == "MonitorPanel")
                {
                    //MonitorPanel _eternalMonitorPanel = new MonitorPanel(parts[0],parts[1],parts[2],Convert.ToInt16(parts[3].Trim()));
                    MonitorPanel _eternalMonitorPanel = new MonitorPanel();
                    MonitorPanels.Add(_eternalMonitorPanel);
                }
                if ( parts[0] == "MonitorPanel")
                {
                    //MonitorPanel _checklistMonitorPanel = new MonitorPanel(parts[0],parts[1],parts[2],Convert.ToInt16(parts[3]),Convert.ToInt16(parts[4]),Convert.ToInt16(parts[5]),Convert.ToInt16(parts[6].Trim()));   
                    MonitorPanel _checklistMonitorPanel = new MonitorPanel();
                    MonitorPanels.Add(_checklistMonitorPanel);

                }
                    
            }
        }
    }
    public void RecordEvent()
    {
        ListNames();
        Console.WriteLine("");
        Console.WriteLine("Which monitor did you accomplish?");
        string _orderEvent = Console.ReadLine();
        foreach ( string _monitorName in MonitorPanelNames)
        {
             string[] parts = _monitorName.Split(new[] { "|" }, StringSplitOptions.None);
             //verifying count
             if (_orderEvent == parts[0])
             {
                // getting type of event
                // if( parts[2] == "MonitorPanel")
                // {
                //     _pointsEarned = MonitorPanels[Convert.ToInt16(parts[1])].getName(); 
                //    MonitorPanels[Convert.ToInt16(parts[1])].setChecked();
                    
                // }
                // if( parts[2] == "MonitorPanel")
                // {
                //     _pointsEarned = MonitorPanels[Convert.ToInt16(parts[1])].getName(); 
                // }
                // if( parts[2] == "MonitorPanel")
                // {
                //     _pointsEarned = MonitorPanels[Convert.ToInt16(parts[1])].getName(); 
                //     int _monitorTimes =MonitorPanels[Convert.ToInt16(parts[1])].getName();  
                //     int _monitorCount =MonitorPanels[Convert.ToInt16(parts[1])].getName();  
                //     _monitorCount++;
                //     MonitorPanels[Convert.ToInt16(parts[1])].setCount(_monitorCount);   
                //     MonitorPanels[Convert.ToInt16(parts[1])].setChecked(_monitorTimes, _monitorCount);
                // }
             }
        }
        _totalPoints += _pointsEarned;
        Console.WriteLine($"Congratulations! You have earned {_pointsEarned} points!");
        Console.WriteLine($"You now have {_totalPoints} points");
    }
} 