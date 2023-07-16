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
                Console.WriteLine($"Battery Status: {battery.getStatus()} ");
                Console.WriteLine($"Inverter Status: {inverter.getStatus()}");
                Console.WriteLine($"Pyranometer Status: {pyranometer.getStatus()}");
                Console.WriteLine($"Recloser Status: {reco.getStatus()} ");
                Console.WriteLine($"Tracker Status: {tracker.getStatus()}");
                Console.WriteLine($"");
                Console.WriteLine($"Press Any Key to go to Menu");
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
            _tecla  = Console.ReadLine();
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