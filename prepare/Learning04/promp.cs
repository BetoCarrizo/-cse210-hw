public class Promp
{
    List<string> acvPromp = new List<string> 
    {
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"
    };
    
    Random acvRandom = new Random();


public string GetRandom()
    {
    int acvList = acvRandom.Next(0, acvPromp.Count);
    
        string acvPrompReturn = acvPromp[acvList];

        return acvPrompReturn;

}
}