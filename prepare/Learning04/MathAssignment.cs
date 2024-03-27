public class MathAssignment  : Assigmnet
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName,string Topic,string textbookSection, string problems):base(studentName,Topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;

    }
    public string GetHomeworkList()
    {
        string HomeworkList = $"{_textbookSection}   {_problems}";
        return HomeworkList;
    }


}