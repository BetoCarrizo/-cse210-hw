using System;
using System.Runtime.CompilerServices;

class Program
{
    public static void acvDisplayMenu()
    {
        Console.WriteLine("More Options:");
        Console.WriteLine("     1. Create New Goal ");
        Console.WriteLine("     2. List Goals  ");
        Console.WriteLine("     3. Save Goals ");
        Console.WriteLine("     4. Load Goals ");
        Console.WriteLine("     5. Record Event ");
        Console.WriteLine("     6. Quit");
    }
    public static void acvDisplayGoalOptions()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("     1. Simple Goal");
        Console.WriteLine("     2.Eternal Goal");
        Console.WriteLine("     3.Checklist Goal");
        Console.WriteLine("Which type of goal you would like to create? ");    
    }
    static void Main(string[] args)
    {   acvSimpleGoal S =new acvSimpleGoal();
        acvCheckList C = new acvCheckList();
        acvEternalGoal E = new acvEternalGoal();
        acvSAveLoad L = new acvSAveLoad ();
        acbGoals.acvGoalss  = new List<object>();
        


        bool acvrunning = true;

        while (acvrunning)
        {
            acvDisplayMenu(); 

            string acvMenuEntry = Console.ReadLine();
            int acvIntMenuEntry = int.Parse(acvMenuEntry);

            if (acvIntMenuEntry == 1)
            {
                acvDisplayGoalOptions();

                string acvGoalOpt = Console.ReadLine();
                int acvIntGoalOpt = int.Parse(acvGoalOpt);
                
                if(acvIntGoalOpt==1)
                {   acbGoals acbGoal = new acvSimpleGoal();
                    acbGoal.acvGoalName(); 
                    acbGoal.acvGetDescrip(); 
                    acbGoal.acvGetPoints(); 
                    acbGoal.acvGetFile();
                    S.runall();
                    L.acv_Createfile(acbGoals.acvGoalss, acbGoals._filePath);
                }
                 if(acvIntGoalOpt==2)
                {
                    E.runall();
                }
                 if(acvIntGoalOpt==3)
                {
                    C.runall();
                }
    
            }
            else if (acvIntMenuEntry == 2)
            {
            }
            else if (acvIntMenuEntry == 3)
            {
                
            
            }
            else if (acvIntMenuEntry == 4)
            {
              

            }
            
             else if (acvIntMenuEntry == 5)
            {
            }
            else if (acvIntMenuEntry == 6)
            {
                Console.WriteLine("Bye!");
                acvrunning = false;
            }
            else
            {
                Console.WriteLine("Insert a valid input");
            }
        }
    }





    }
