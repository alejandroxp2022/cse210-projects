using System;
using System.Collections.Generic;
using System.IO;


class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"Date: {entry._date.ToShortDateString()} - Prompt: {entry._prompt}:\n {entry._response}");
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
           //     outputFile.WriteLine(entry.ToString());
                outputFile.WriteLine($"{entry._date.ToShortDateString()}|{entry._prompt}|{entry._response}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        // To not load entries repeatedly 
        entries.Clear();

        using (StreamReader inputFile = new StreamReader(filename))
        {
            while (!inputFile.EndOfStream)
            {
                string line = inputFile.ReadLine();
                //string[] parts = line.Split(new[] { " - Prompt: " }, StringSplitOptions.None);
                string[] parts = line.Split(new[] { "|" }, StringSplitOptions.None);
                //DateTime date = DateTime.ParseExact(parts[0].Replace("Date: ", ""), "M/d/yyyy", null);
                DateTime date = DateTime.ParseExact(parts[0], "M/d/yyyy", null);

                //string prompt = parts[1].Split(':')[0].Trim();
                string prompt = parts[1];
                //Console.WriteLine($"Prompt part: {prompt}");
                    
                //string response = parts[1].Split(':')[1].Trim();
                string response = parts[2].Trim();
                //Console.WriteLine($"Response part: {response}");
            
                Entry entry = new Entry(prompt, response);
                entry._date = date;
                entries.Add(entry);
            }
        }
    }
}