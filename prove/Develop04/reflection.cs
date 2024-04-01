public class acvReflection : acvActivity
{
    private string acvName = "Reflection";


    private List<string> acvReflexPromp = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };

    private List<string> acvReflexQuestions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    private string acvGetRandomQuestion()
    {
        Random acvRandomQues = new Random();
        int acvRandomReflexPromp = acvRandomQues.Next(0, acvReflexPromp.Count);
        string acvReflexReturn = acvReflexPromp[acvRandomReflexPromp];

        return acvReflexReturn;
    }

    private string acvGetRandomPrompt()
    {
        Random acvRandomPromp = new Random();
        int acvRandomReflexQue = acvRandomPromp.Next(0, acvReflexQuestions.Count);
        string acvReflexReturnQue = acvReflexQuestions[acvRandomReflexQue];

        return acvReflexReturnQue;
    }

    public override void acvStartingMessage()
    {
    // Console.Clear();
        Console.WriteLine("Welcome to the " + acvName + " Activity\n");
        startR();
        _acvSessionDuration = AcvDuration();
        Console.WriteLine("Get Ready...\n");
        acv_GetReady();
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine("--- " + acvGetRandomPrompt() + " ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.\n");
        string acvEnterInput = Console.ReadLine();
        if (acvEnterInput == "")
        {
            acvRun_R();
        }
    }

    public void acvRun_R()
    {

        DateTime acvExerciseTime = DateTime.Now;
        DateTime acvNextQuestionTime = acvExerciseTime.AddSeconds(5);
        DateTime acvEndExercise = acvExerciseTime.AddSeconds(_acvSessionDuration);

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.\n ");
        acvMayBegin();
       // Console.Clear();
        Console.Write("You might begin in: ");

        while (DateTime.Now < acvEndExercise)
        {
            Console.WriteLine(acvGetRandomQuestion());
            Thread.Sleep(3000);
        }
        acvFinishMessage();
    }
    

    private void acvFinishMessage()
    {
        Console.WriteLine("Well done!!\n");
        acv_GetReady();
        Console.WriteLine("You have completed another " + _acvSessionDuration + " seconds of " + acvName + " Activity \n");
        acv_GetReady();
    }
}








    
