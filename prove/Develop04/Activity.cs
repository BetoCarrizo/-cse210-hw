
using System.Threading.Tasks.Dataflow;

public abstract class acvActivity
{
/// <summary>
/// protected int _acvSessionDuration;
/// </summary>

public int _acvSessionDuration;


    protected int AcvSessionDuration
    {
        get { return _acvSessionDuration; }
        set { _acvSessionDuration = value; }
    }


//differnt start messages
 public void startR()
        {
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n");
        }
        public void startL()
        {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");
        }
        public void startB()
        {
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
        }



public List<string> acvAnimation = new List<string>();
    
    
    public void acvAddAnimationL()
    {   //   |/-\|/-\| (|=alt +124)
        acvAnimation.Add("|");
        acvAnimation.Add("/");
        acvAnimation.Add("-");
        acvAnimation.Add("\\");
    }

//animation Fix Needed
    public void acv_GetReady()
    {
         

        DateTime acvWaitTime = DateTime.Now;
        DateTime acvEndWait = acvWaitTime.AddSeconds(5);

        int StartList=0;
        while (DateTime.Now < acvWaitTime)
        {
            string acvListAnimation = acvAnimation[StartList];
            Console.WriteLine(acvListAnimation);
            Thread.Sleep(500);
            Console.WriteLine("\b \b");

            StartList++;

            if (StartList >acvAnimation.Count)
            {
                StartList= 0;
            }
        }
    }

public void acvMayBegin()
{
    Console.Write("You might begin in: ");
        for (int acvCountDown = 5; acvCountDown > 0; acvCountDown--)
        {
            Console.Write(acvCountDown);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
}



  public int AcvDuration()
    {
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        string acvInput = Console.ReadLine();
        int duration = 0;

        if (int.TryParse(acvInput, out duration))
        {
            _acvSessionDuration = duration;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer value.");
            AcvDuration(); 
        }

        return _acvSessionDuration;
    }

        public abstract void acvStartingMessage();
        
 


}











