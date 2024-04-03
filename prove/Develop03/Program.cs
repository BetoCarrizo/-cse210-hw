public class Program
{
    public static void Main(string[] args)
    {   
        acvScripture a = new acvScripture();
        acvMenu m = new acvMenu();

        bool done = false;
        while (done == false)
        {
        m.acvMenuu();
        string acvMenuinput = Console.ReadLine();
            if (acvMenuinput=="1") 
            {
                a.acvGEtRandomScripture();
            }
            else if (acvMenuinput=="2" )
            {
                a.acvScriMemo();
            }
            else if (acvMenuinput == "quit")
            {
                Console.Write("Bye!");
                done = true;
            }
        }
    }
}
