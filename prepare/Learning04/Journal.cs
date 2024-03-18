
public class Journal
{
List<string> acvPromAndEntry = new List<string>();

    public string acvFileName;
    public string acvUserInput;

    public void Displays()
    {
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do? ");

    
    }
    
        
        
       
    public void acvSave()
{
    string acvfilename = acvFileName;

    using (StreamWriter writer = new StreamWriter(acvfilename))
    {
        foreach (string acvline in acvPromAndEntry)
        {
            writer.WriteLine(acvline);
        }
        Console.WriteLine($"File '{acvfilename}' saved successfully.");
    }
}

  public void acvLoad()
{
    string acvfilename = acvFileName;

    if (File.Exists(acvfilename))
    {
        acvPromAndEntry.AddRange(File.ReadAllLines(acvfilename));
        Console.WriteLine($"File '{acvfilename}' loaded successfully.");
    }
    else
    {
        using (StreamWriter writer = new StreamWriter(acvfilename))
        {
            Console.WriteLine($"File '{acvfilename}' created.");
        }
    }
}

    public void Entry()
    {


        
        Promp acvPromp = new Promp(); 
        Imput acvInput = new Imput();
        Date acvDate = new Date();
        

        
        
        
        
      
}

}