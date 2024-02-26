using System;
using System.Net;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        Journal currentJournal = new Journal();
        
        Console.WriteLine("Welcome to the Journal Program!\nPlease selet one of the following choices:");

        while (exit!=true) {
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.WriteLine("What would you like to do?");
            string choice = Console.ReadLine();

            switch (choice) {
                case "1":
                    Console.WriteLine("You have selected: Write");
                    Entry currentEntry = new Entry();
                    string currentPrompt = Prompter.PromptRandom();
                    string response = Console.ReadLine();
                    currentEntry.SaveEntry(currentPrompt, response);
                    currentJournal.AddEntry(currentEntry);
                    break;
            }

            switch (choice) {
                case "2":
                    Console.WriteLine("You have selected: Display");
                    currentJournal.DisplayJournal();

                    break;
            }

            switch (choice) {
                case "3":
                    Console.WriteLine("Load");
                    break;
            }

            switch (choice) {
                case "4":
                    Console.WriteLine("Save");
                    break;
            }

            switch (choice) {
                case "5":
                    exit = true;
                    break;
            }
        }
    }
}