using System;

public class Scripture
{
    private Reference _reference;
    private string _text;
    private List<Word> _words = new();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        string[] words = text.Split();
        foreach(string word in words)
        {
            Word wordObj = new(word);
            _words.Add(wordObj);
        }
    }

    public void Display()
    {
        Console.Write(_reference.GetRefString() + " ");
        foreach(Word word in _words)
        {
            Console.Write(word.GetWord() + " ");
        }
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        int index;

        do //the do ... while loop is to find the word that hasnt been hidden yet
        {
            index = random.Next(_words.Count);

        } while ( _words[index].GetIsHidden() );

        _words[index].SetIsHidden(true);
    }

    public bool AllWordsHidden()
    {
        foreach(Word word in _words)
        {
            if (!word.GetIsHidden())
            {
                return false;
            }
        }
        return true;
    }
}