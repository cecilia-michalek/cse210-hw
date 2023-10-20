using System;
public class Word
{
    private string _word;
    private string _hidden;
    private bool _isHidden = false;

    public Word(string word)
    {
        _word = word;
        foreach (char letter in word)
        {
            _hidden += "_";
        }
    }

    public string GetWord()
    {
        if (_isHidden)
            return _hidden;
        else
            return _word;
    }

    public void SetIsHidden(bool status)
    {
        _isHidden = status;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }



}
