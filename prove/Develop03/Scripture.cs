using System;
using System.ComponentModel.DataAnnotations;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] word = text.Split(' ');
        foreach (string i in word)
        {
            Word w = new Word(i);
            _words.Add(w);
        }
    }
    
    public void HideRandomWords(int numberToHide)
    {
        Random randomGenerator = new Random();
        List<Word> visibleWords = new List<Word>();
       
       foreach (Word word in _words)
       {
        if (word.IsHidden() != true)
        {
            visibleWords.Add(word);
        }
       }
       foreach (Word i in visibleWords)
       {
            numberToHide = randomGenerator.Next(visibleWords.Count);
            i.Hide();
       }
    }

    public string GetDisplayText()
    {
        string reference = _reference.GetDisplayText();
        string text = string.Empty;
        foreach (Word word in _words)
        {
            text = word.GetDisplayText() + " ";
        }
        
        return reference + text;
        
    }

    public bool IsCompletelyHidden()
    {
        int i = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden() != true)
            {
                i += 1;
            }
        }

        if (i == 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}