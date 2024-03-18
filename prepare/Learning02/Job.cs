public class Job
    {
        public string company;
        public string jobTitle;    
        public int statYear;
        public int endYear;
        public void Display()
    {
        Console.WriteLine($"{jobTitle} ({company}) {statYear}-{endYear}");
    }
    }
