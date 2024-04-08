using System.ComponentModel;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

public abstract class acbGoals
{
    private static string _acvNameGoal;
    private static bool _completed;
    private static int _points;
    private static  string _acvInputSimpleDG;
    public static string _filePath;
    public static List<object> acvGoalss = new List<object>();
    
    
    public string acvSetFileNAme()
    {
        return _filePath;
    }
    public string acvSetNameGoal()
    {
       return _acvNameGoal;
    }
    public bool acvSetCompleated()
    {
        return _completed;
    }
    public int acvSetPoints()
    {
        return _points;
    }
    public string acvSetDescription()
    {
        return _acvInputSimpleDG;
    }

    public void acvGetFileName(string acv_filePath)
    {
        _filePath =  acv_filePath;
    }
     public void acvGetNameGoal(string acvNameGoal)
    {
        _acvNameGoal=acvNameGoal;
    }

    public void acvGetCompleated(bool completed)
    {
        _completed= completed;
    }
    public void acvGetPoints(int points)
    {
        _points=points;
    }
    public void acvGetDescription(string acvInputSimpleDG)
    {
        _acvInputSimpleDG=acvInputSimpleDG;
    }
    public void acvGetFile()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string acvSetNameGoals=Console.ReadLine();
        _acvNameGoal=acvSetNameGoals;
    }

    public void acvGetNameGoals()
    {
        Console.WriteLine("What is the name of your goal? ");
        string acvSetNameGoals=Console.ReadLine();
        _acvNameGoal=acvSetNameGoals;
    }
    public void acvGetDescriptions()
    {
        Console.WriteLine("What is a short description of it? ");
        string acvInputSimpleDGs= Console.ReadLine();
        _acvInputSimpleDG=acvInputSimpleDGs;

    }
     public void acvGetPoints()
    {
        Console.WriteLine("What is the amount of point associated with this goal? ");
        string acvGetPointsString = Console.ReadLine();
        int acvGetPointInt= int.Parse(acvGetPointsString);
        _points=acvGetPointInt;
    }
    
    public void acvGetCompleated()
    {
        _completed= false;
    }


    public static void SimpleList()
    {   
        
        acvGoalss.Add(_acvNameGoal);
        acvGoalss.Add(_acvInputSimpleDG);
        acvGoalss.Add(_points);
        acvGoalss.Add(_completed);


        acvSAveLoad saver = new acvSAveLoad();

        saver.acv_Createfile(acvGoalss, _filePath);
    }

     public static void Eternal()
    {   
        
        acvGoalss.Add(_acvNameGoal);
        acvGoalss.Add(_acvInputSimpleDG);
        acvGoalss.Add(_points);


        acvSAveLoad saver = new acvSAveLoad();

        saver.acv_Createfile(acvGoalss, _filePath);
    }


  







    ///----------------------------------------------------------------------------------------------------
public abstract void acvList();
public abstract void acvMarkComplete();
public abstract void acvCalcPoints();
public abstract void acvGoalName();
public abstract void acvGetDescrip();


























} 


























