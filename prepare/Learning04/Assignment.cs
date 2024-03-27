
using System.Dynamic;

public class Assigmnet
{
    private string _studentName;
    private string _Topic;

    public Assigmnet(string studentName,string Topic)
    {
        _studentName = studentName;
        _Topic = Topic;
    }
    public string GetSumary()
    {
        string Sumary= $"{_studentName} - {_Topic}";
        return Sumary;
    }





















}
















