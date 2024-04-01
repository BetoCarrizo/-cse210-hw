    
    
public class acvListing : acvActivity
{
    private string acvName = "Listing";
    private List<string> acvQuestion = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    

    

    private string acvGetRandomQuestion()
    {
        Random acvRandomQuestion = new Random();
        int acvRandomQuestionList = acvRandomQuestion.Next(0, acvQuestion.Count);
        string acvRandomQ = acvQuestion[acvRandomQuestionList];
        return acvRandomQ;
    }

    public override void acvStartingMessage()
    {
        Console.WriteLine("Welcome to the " + acvName + " Activity\n");
        base.startR();
        base.acv_GetReady();
        acvRun_L();
    }

    private void acvFinishMessage()
    {
        Console.WriteLine("Well done \n");
        base.acv_GetReady();

        Console.WriteLine("You have completed another " + _acvSessionDuration + " seconds of " + acvName + " Activity \n");
        base.acv_GetReady();
    }

    public void acvRun_L()
    {
        List<string> acvAnswersList = new List<string>();
        
        Console.WriteLine("List as many responses as you can to the following prompt: \n");
        Console.WriteLine("---" + acvGetRandomQuestion() + "---");
    base.acvMayBegin();
        DateTime acvExerciseTime = DateTime.Now;
        DateTime acvEndExercise = acvExerciseTime.AddSeconds(base.AcvDuration());
        while (DateTime.Now < acvEndExercise)
        {
            if (Console.KeyAvailable)
            {
                Console.Write(">");
                string acvInputAnswer = Console.ReadLine();
                acvAnswersList.Add(acvInputAnswer);
            }
        }
        int acvAnswerNumber = acvAnswersList.Count();
        Console.WriteLine("You listed " + acvAnswerNumber + " items! \n");
        acvFinishMessage();
    }

}
