using System.Runtime.InteropServices;

public class acvSimpleGoal:acbGoals
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
        acvList();
    }










    
}