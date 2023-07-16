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
                Console.WriteLine("MONITORING");
                Console.WriteLine("==========");
                Console.WriteLine($"");
                Console.WriteLine("Power Plant Live Status:");
                Console.WriteLine($"Tracker Status: Name: {tracker.getName()} - {tracker.getStatus()} - {tracker.getDesc()} - IP:{tracker.getIP()}");
                Console.WriteLine($"Inverter Status: Name: {inverter.getName()} - {inverter.getStatus()} - {inverter.getDesc()} - IP:{inverter.getIP()}");
                Console.WriteLine($"Battery Status: Name: {battery.getName()} - {battery.getStatus()} - {battery.getDesc()} - IP:{battery.getIP()}");
                Console.WriteLine($"Recloser Status: Name: {reco.getName()} - {reco.getStatus()} - {reco.getDesc()} - IP:{reco.getIP()}");
                Console.WriteLine($"Meteo Station Status: Name: {meteoStation.getName()} - {meteoStation.getStatus()} - {meteoStation.getDesc()} - IP:{meteoStation.getIP()}");
                Console.WriteLine($"Pyranometer Status: Name: {pyranometer.getName()} - {pyranometer.getStatus()} - {pyranometer.getDesc()} - IP:{pyranometer.getIP()}");
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
            Console.WriteLine("     5. Record Events");
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
                    powerPlantManager.LoadGoals();
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