
using System.Threading.Tasks.Dataflow;

public class Journal
{

        Promp acvPromp = new Promp();
        Imput acvInput = new Imput();
        Date acvDate= new Date(); 
        public List<string> acvPromAndEntry = new List<string>();
        public string acvFileName;
    
    
///public string acvUserInput;

 public Journal(string fileName)
    {
        acvFileName = fileName;
    }

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
    // Check if the file name is empty
    if (string.IsNullOrEmpty(acvFileName))
    {
        Console.WriteLine("Journal file name is not set. Enter file name:");
        acvFileName = Console.ReadLine();
    }

    // Use the class-level acvFileName property
    string acvfilename = acvFileName;

    try
    {
        using (StreamWriter writer = new StreamWriter(acvfilename))
        {
        foreach(string acvitem in acvPromAndEntry){
            writer.WriteLine(acvitem);

        }


             
            
        }
        Console.WriteLine($"File '{acvfilename}' saved successfully.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error saving file '{acvfilename}': {ex.Message}");
    }
}

  public void acvLoad()
  
{
    Console.WriteLine("Enter journal file name: ");
    string acvFileName = Console.ReadLine();
        
        
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
