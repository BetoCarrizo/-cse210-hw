using System.ComponentModel;
using System.Runtime.InteropServices;
using System.IO;
using System.Linq;


public class acvScripture
{ 
    private List<acvWords> acvScriptures;
    private string _acvRef;
    private string filePath = "C:\\Users\\Alber\\OneDrive\\Desktop\\Clases Winter 2024\\CSE210\\-cse210-hw\\prove\\Develop03\\Script.txt";
    private Dictionary<string, List<acvWords>> acvDictionaryScrip = new Dictionary<string, List<acvWords>>();

    public  acvScripture()
    {
        string[] acvRlines = System.IO.File.ReadAllLines(filePath);
        foreach (string lines in acvRlines)
        {
            string[] acvKeyArray = lines.Split('|');
            string acvReference = acvKeyArray[0];
            string acvPassages = acvKeyArray[1];

            List<acvWords> _acvWords = new List<acvWords>();
            string[] acvWordArray = acvPassages.Split(" ");

            foreach (string acvword in acvWordArray)
        {   
            acvWords acvWordOb = new acvWords(acvword); 
            acvWordOb.acvSetWord(acvword);
            _acvWords.Add(acvWordOb);
        }
        acvDictionaryScrip.Add(acvReference, _acvWords);
        }
    }
   public void acvScriMemo()
{
     while (true)
    {
        Console.Clear();
        Console.Write(_acvRef);
        

        foreach (acvWords acvword in acvScriptures)
        {
            if (acvword.acvGetIsHiden() == false)
            {
                Console.Write(acvword.acvGetWord() + " ");
            }
            else
            {
                foreach (char letter in acvword.acvGetWord())
                {
                    Console.Write("_");
                }
                Console.Write(" ");
            }
        }

        Console.WriteLine("\n\nPress any key to hide a word in the scripture or 3 to leave");
        string input = Console.ReadLine();

        if (input == "3")
        {
            return;
        }
        else
        {
            for (int i = 0; i < 5; i++)
            {
                acvHideWord();
            }
        }
    }
}
public void acvHideWord()
{
    Random acvrandom = new Random();

    
    int wordsHidden = 2;

    
    while (wordsHidden == 2)
    {
        
        int index = acvrandom.Next(acvScriptures.Count);

        
        acvWords acvword = acvScriptures[index];

        if (!acvword.acvGetIsHiden())
        {
            acvword.acvHideWord();
            wordsHidden++;
        }
    }
}

public void acvGEtRandomScripture()
{
    Random random = new Random();
    int randomIndex = random.Next(acvDictionaryScrip.Count);
    
    _acvRef = acvDictionaryScrip.Keys.ElementAt(randomIndex);
    acvScriptures = acvDictionaryScrip[_acvRef];
    Console.WriteLine(_acvRef);
    Console.WriteLine();
}
}