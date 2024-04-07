public class acvEternalGoal:acbGoals
{   
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
   public override void acvList()
    {
        SimpleList();
    }
    public void runall()
    {
        acvGoalName();
        acvGetDescrip();
        acvCalcPoints();
        acvMarkComplete();
    }
}