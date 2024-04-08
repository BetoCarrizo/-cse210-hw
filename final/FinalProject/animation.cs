public class acvAnimation
{ 
    public static List<string> animation = new List<string>();
  
    public void AcvAnimation()
    {
        animation = new List<string>();
        animation = new List<string>();
        animation.Add("|");
        animation.Add("\\");
        animation.Add("-");
        animation.Add("/");
        animation.Add("|");
        animation.Add("\\");
        animation.Add("-");
    for (int i = 0; i < animation.Count; i++){
        Console.Write(animation[i]);
        Thread.Sleep(500);
        Console.Write("\b \b");}
    }
}