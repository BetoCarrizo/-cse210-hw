public class acvCheckList:acbGoals
{   private int _BonusTime;
    private int _BonusPoints;
    public int acvSetBonusPoints()
    {
        return _BonusPoints;
    }
    public void acvGetBonusPoints(int acvBonusPoints)
    {
        _BonusPoints=acvBonusPoints;
    }
    public int acvSetTimeBonus()
    {
        return _BonusTime;
    }
    public void acvGetTimeBonus(int acvGetTimesB)
    {
        _BonusTime=acvGetTimesB;
    }
    public override void acvGoalName()
    {
        base.acvGetNameGoals();
    }
    public override void acvGetDescrip()
    {
        base.acvGetDescriptions();
    }
    public override void acvCalcPoints()
    {
        base.acvGetPoints();
    }
    public override void acvMarkComplete()
    {
       base.acvGetCompleated();
    }
    public void acvTimesBonusPoints()
    {
        Console.WriteLine("How many times does this goal nees to be acomplished for a bonus? ");
        string acvTimeBonus = Console.ReadLine();
        int acvGetTimesB= int.Parse(acvTimeBonus);
        acvGetTimesB=_BonusTime;
    }
    public void acvBonusPoints()
    {
        Console.WriteLine("How many times does this goal nees to be acomplished for a bonus? ");
        string acvBonusPoint = Console.ReadLine();
        int acvBonusPoints= int.Parse(acvBonusPoint);
        acvBonusPoints=_BonusPoints;
    }
    public override void acvList()
    {


    }
    public void runall()
    {
        acvGoalName();
        acvGetDescrip();
        acvCalcPoints();
        acvMarkComplete();
        acvTimesBonusPoints();
        acvBonusPoints();

    }
}