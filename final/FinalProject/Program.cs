using System;

class Program
{
    static void Main(string[] args)
    {
        string _tecla;
        Tracker tracker = new Tracker();
        Inverter inverter = new Inverter();
        Battery battery = new Battery();
        Recloser reco = new Recloser();
        MeteoStation meteoStation = new MeteoStation();
        Pyranometer pyranometer = new Pyranometer();
        PowerPlantManager powerPlantManager = new PowerPlantManager();
        do {
            while (!Console.KeyAvailable) {
                Console.Clear();
                System.Threading.Thread.Sleep(300);
                DateTime currentDateTime = DateTime.Now;
                Console.WriteLine("Current date and time: " + currentDateTime);
                Console.WriteLine($"");
                Console.WriteLine("MONITORING");
                Console.WriteLine("================================");
                Console.WriteLine("Power Plant Live Status:");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Name - Status - Description - IP");
                Console.WriteLine("--------------------------------");
                foreach( EnergyDevice device in powerPlantManager.Devices)
                {
                    Console.WriteLine($"{device.getName()} Status: {device.getStatus()} - {device.getDesc()} - IP:{device.getIP()}");
                }
                Console.WriteLine($"");
                Console.WriteLine($"Press Space Bar twice to access the Menu");
                System.Threading.Thread.Sleep(3000);
            } 
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Create New Entity");
            Console.WriteLine("     2. List Devices");
            Console.WriteLine("     3. Save Power Plant Image");
            Console.WriteLine("     4. Load Power Plant Image");
          //  Console.WriteLine("     5. Record Events");
            Console.WriteLine("     6. Quit");
            Console.Write("Select a choice from the menu: ");
            _tecla  = Console.ReadLine().Trim();
            switch (_tecla)
            {
                case "1": 
                    powerPlantManager.CreatePowerPlant(tracker, inverter, battery, reco, meteoStation, pyranometer);
                    break;
                case "2": 
                    powerPlantManager.ListNames();
                    break;
                case "3":
                    powerPlantManager.SaveAllDevices();
                    break;
                case "4":
                    powerPlantManager.LoadDevices();
                    break;
                case "5":
                    break;
                case "6":
                    Console.WriteLine("Good Bye.");
                    break;
                default:
                    Console.WriteLine("Please select the right option.");
                    break;

            }

        } while (_tecla != "6");
    }
}