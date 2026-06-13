using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if(_isHidden)
        {
            //need something that replaces words with underscores of similar or equal length to help get the brain thinking
            return new string('_', _text.Length); //think about it conseptually use this to fill in the blanks
            //had an error above make sure to single quotes and not double for arguments.
        }
        else
        {
            //in case their is no change or just needing to make sure it only replaces the randomized words. 
            return _text;
        }
    }
}