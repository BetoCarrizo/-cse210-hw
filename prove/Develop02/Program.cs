using System;
using System.ComponentModel;
using System.IO.Pipes;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;




public class Program
{

static void Main(string[]args)
{      
    
        string acvFileName = "";
        Journal acvJournal = new Journal(acvFileName);
        Promp acvPromp = new Promp();
        Imput acvInput = new Imput();
        Date acvDate= new Date();
bool keeruning=true;
List<string> acvPromAndEntry = new List<string>();
    while (keeruning)
        {
            acvJournal.Displays();

            string acvMenuEntry = Console.ReadLine();
            int acvIntMenuEntry = int.Parse(acvMenuEntry);

            if (acvIntMenuEntry == 1)
            {
                string acvSelectedPrompt = acvPromp.GetRandom();
                acvPromAndEntry.Add(acvSelectedPrompt);

                Console.WriteLine(acvSelectedPrompt);
                string acvJournalEntry = Console.ReadLine();

                acvPromAndEntry.Add(acvJournalEntry);
            }
            else if (acvIntMenuEntry == 2)
            {
                    

                    Console.WriteLine("Entries: ");
                foreach (string sentence in acvPromAndEntry)
                {
                    Console.WriteLine(acvDate.Outputs()+sentence);
                }
            }
            else if (acvIntMenuEntry == 3)
            {
                acvJournal.acvLoad();
            }
            else if (acvIntMenuEntry == 4)
            {
              
                acvJournal.acvSave();
                

            }
            else if (acvIntMenuEntry == 5)
            {
                Console.WriteLine("Good Bye User. ");
                keeruning=false;
                 
            }
    }
    
    }}







    