using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;

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

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        if(_isHidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public string GetDisplayText()
    {
        if(IsHidden()==true)
        {
            string wordTodisplay = new string('_',_text.Length);
            return wordTodisplay;
        }
        else
        {
            string wordTodisplay = _text;
            return wordTodisplay;
        }
    }
}