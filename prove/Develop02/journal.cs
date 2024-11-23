using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    public class Journal
    {
        private List<JournalEntry> entries = new List<JournalEntry>();

        public void AddEntry(JournalEntry entry)
        {
            entries.Add(entry);
        }

        public void DisplayEntries()
        {
            if (entries.Count == 0)
            {
                Console.WriteLine("No entries in the journal yet.");
                return;
            }

            foreach (var entry in entries)
            {
                Console.WriteLine();
                entry.PrintEntry();
            }
        }

        public void SaveToFile(string filename)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (var entry in entries)
                    {
                        writer.WriteLine($"{entry.Date}~|~{entry.Prompt}~|~{entry.Response}");
                    }
                }
                Console.WriteLine($"Journal saved to {filename}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving journal to file: {ex.Message}");
            }
        }

        public void LoadFromFile(string filename)
        {
            try
            {
                entries.Clear(); 

                using (StreamReader reader = new StreamReader(filename))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(new[] { "~|~" }, StringSplitOptions.None);
                        if (parts.Length == 3)
                        {
                            var date = parts[0];
                            var prompt = parts[1];
                            var response = parts[2];

                            var entry = new JournalEntry(prompt, response, date);
                            AddEntry(entry);
                        }
                    }
                }
                Console.WriteLine($"Journal loaded from {filename}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading journal from file: {ex.Message}");
            }
        }
    }
}
