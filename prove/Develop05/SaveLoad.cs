

public class acvSAveLoad
{
    public void acv_Createfile(List<object> GoalList, string _filePath)
    {
        if (string.IsNullOrEmpty(_filePath))
        {
            _filePath = "default_file.txt";
        }
            using (StreamWriter writer = new StreamWriter(_filePath))
        
            {
                foreach (var item in GoalList)
                {
                    writer.WriteLine(item);
                } 
            }
    }
    public void acv_Loadfile(List<object> parameters , string _filePath)
    {   
        if (!File.Exists(_filePath))
        {
            throw new FileNotFoundException("File not found.", _filePath);
        }
        using (StreamReader reader = new StreamReader(_filePath))
        {
            string acvline;

            while ((acvline = reader.ReadLine()) != null)
            {
                string[] acvparts = acvline.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string item in acvparts)
                {
                    parameters.Add(item.Trim());
                }
            }
        }
    }
    public void acvDefaultCLear(string _filePath)
    {
        File.WriteAllText(_filePath, string.Empty);
    }

    public void DefaultacvClear_File()
    {
        string defaultFilePath = "default_file.txt";
        acvDefaultCLear(defaultFilePath);
    }


}























 