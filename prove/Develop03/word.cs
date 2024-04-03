


public class acvWords
{  
    private string acv_Words;
    private bool acv_isHidden;


     public acvWords(string word)
    {
        acv_Words = word;
        acv_isHidden = false;
    }


    public bool acvGetIsHiden()
    {
        return acv_isHidden;

    }

    public string acvGetWord()
    {
        return acv_Words;

    }

    public void acvSetWord(string valu)
    {
        acv_Words = valu;
    }

    public void acvHideWord()
    {
        acv_isHidden = true;

    }
    
          


}

