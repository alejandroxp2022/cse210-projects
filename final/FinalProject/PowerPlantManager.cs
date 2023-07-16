using System;

class PowerPlantManager
{
    //fields

    List<EnergyDevice> Devices = new List<EnergyDevice>();
    protected string _filename;
    private string _separator = "|";
    public int _totalPoints;

    public PowerPlantManager()
    {
        /*Tracker tracker = new Tracker();
        Inverter inverter = new Inverter();
        Battery battery = new Battery();
        Recloser reco = new Recloser();
        MeteoStation meteoStation = new MeteoStation();
        Pyranometer pyranometer = new Pyranometer();*/
    }
    public void CreatePowerPlant( EnergyDevice tracker, EnergyDevice inverter, EnergyDevice battery, EnergyDevice reco, EnergyDevice meteoStation, EnergyDevice pyranometer)
    {
        /**Tracker tracker = new Tracker();
        Inverter inverter = new Inverter();
        Battery battery = new Battery();
        Recloser reco = new Recloser();
        MeteoStation meteoStation = new MeteoStation();
        Pyranometer pyranometer = new Pyranometer();**/

        string _tecla2;
        Console.WriteLine("Available Devices are:");
                    Console.WriteLine("     1. Tracker");
                    Console.WriteLine("     2. Inverter");
                    Console.WriteLine("     3. Battery");
                    Console.WriteLine("     4. Recloser");
                    Console.WriteLine("     5. Meteorological Station");
                    Console.WriteLine("     6. Pyranometer");
                    Console.WriteLine("Which type of device would you like to create?");
                    _tecla2  = Console.ReadLine().Trim();
                    switch (_tecla2)
                    {
                        case "1":
                            tracker.CreateDevice();
                            Devices.Add(tracker);
                            break;
                        case "2":
                            inverter.CreateDevice();
                            Devices.Add(inverter);
                            break;
                        case "3":
                            battery.CreateDevice();
                            Devices.Add(battery);
                            break;
                        case "4":
                            reco.CreateDevice();
                            Devices.Add(reco);
                            break;
                        case "5":
                            meteoStation.CreateDevice();
                            Devices.Add(meteoStation);
                            break;
                        case "6":
                            pyranometer.CreateDevice();
                            Devices.Add(pyranometer);
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
        foreach ( EnergyDevice device in Devices)
        {
            if(device != null)
            {
                counter++;
                internal_counter++;
                string value = $"{counter.ToString()}.- {device.getName()}";
                Console.WriteLine(value);
            //    GoalNames.Add($"{counter.ToString()}|{internal_counter.ToString()}|EnergyGenerator|{entity.getName()} ");
            }
        }
        internal_counter = -1 ;
        /**foreach ( EnergyTransformer entity in EnergyTransformers)
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
        } **/
    }
    public string getStatus( EnergyDevice device)
    {
        return device.getStatus();
    }
    public void SaveAllDevices()
    {
        Console.WriteLine("What is the filename for the entity file?");
        _filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            //now the entitys by type
            foreach (EnergyDevice device in Devices)
            {
                outputFile.WriteLine($"{device.getType()}.{_separator}{device.getName()}{_separator}{device.getDesc()}{_separator}{device.getStatus()}{_separator}{device.getIP()}");
            }
            /**foreach (EnergyTransformer device in EnergyTransformers)
            {
                outputFile.WriteLine($"EnergyTransformer{_separator}{device.getName()}{_separator}{device.getDesc()}{_separator}{device.getName()}");
            }
            foreach (EnergyTransmit device in EnergyTransmits)
            {
                outputFile.WriteLine($"EnergyTransmit{_separator}{device.getName()}{_separator}{device.getDesc()}{_separator}{device.getName()}{_separator}{device.getName()}{_separator}{device.getName()}{_separator}{device.getName()}");
            } **/
          
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
                    Battery battery = new Battery();
                    Devices.Add(battery);

                }
                if ( parts[0] == "Tracker")
                {
                    Tracker tracker = new Tracker();
                    Devices.Add(tracker);
                }
                if ( parts[0] == "Inverter")
                {
                    Inverter inverter = new Inverter();
                    Devices.Add(inverter);

                }
                    
            }
        }
    }
} 