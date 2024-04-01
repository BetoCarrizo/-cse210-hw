public class acvBreathing:acvActivity
{
private string acvName="Breathing";




    
    public override void acvStartingMessage()
    {
    // Console.Clear();
    Console.WriteLine("Welcome to the " + acvName + " Activity\n");
    base.startB();
    base.AcvDuration();
    // Console.Clear();
    Console.WriteLine("Get Ready...\n");  
    base.acv_GetReady();
    _acvrunb();
    }

    public void _acvrunb()
    {
        
        DateTime acvExerciseTime = DateTime.Now;
        DateTime acvEndExercise = acvExerciseTime.AddSeconds(_acvSessionDuration); 
        while (DateTime.Now < acvEndExercise)
        {
            Console.Write("Breath in... ");
            acvTimeLap();
            Console.WriteLine("");
            Console.Write("Now breath out... ");
            acvTimeLap();
            Console.WriteLine("\n\n");
        }
        acvFinishMessage();
                  
        }
        
    private void acvFinishMessage()
    {
        Console.WriteLine("Well done!! \n");
        base.acv_GetReady();
        Console.WriteLine("You have completed another "+ _acvSessionDuration +  " seconds of " +acvName+   " Activity \n");
        base.acv_GetReady();
        // Console.Clear();
    }


    public void acvTimeLap()
    {
        for (int acvCountDown = 3; acvCountDown > 0; acvCountDown--)
        {
            Console.Write(acvCountDown);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    


    }


