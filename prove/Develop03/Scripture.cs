using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] word = text.Split(" ");
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
        int j = numberToHide;
       do
       {
        foreach (Word word in _words)
        {
            if (word.IsHidden() != true)
            {
                visibleWords.Add(word);
            }
        }

            int index = randomGenerator.Next(visibleWords.Count);
            if (visibleWords.Count != 0)
            {
                Word wordToHide = visibleWords.ElementAt(index);
                wordToHide.Hide();
                j = j - 1;
            }
            if (visibleWords.Count == 0)
            {
                break;
            }
       }while (j != 0);
    }

    public string GetDisplayText()
    {
        string reference = _reference.GetDisplayText();
        string text = "";
        string scripture ="";
        List<string> textToDisplay = new List<string>();
        foreach (Word word in _words)
        {
           text = word.GetDisplayText();
           textToDisplay.Add(text);
        }
        
        foreach (string word in textToDisplay)
        {
            scripture = string.Join(" ",textToDisplay);
        }
        return reference+ " " + scripture;
        
    }

    public bool IsCompletelyHidden()
    {
        int i = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden() != true)
            {
                
                i = i + 1;
            }
        }

        if (i > 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}