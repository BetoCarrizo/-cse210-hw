public class WritingAssignment : Assigmnet
{
    private string _title;

    public  WritingAssignment(string studentName,string Topic,string title):base(studentName,Topic)
    {
        _title=title;
    }

    public string GetWritingInformation()
    {
        string info=_title;
        return info;
    }












}