using System.Net.Http.Headers;
using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What scripture passage does constantly enters my mind now?");
        _prompts.Add("What am I grateful for today?");
        _prompts.Add("What thought did uplift me today?");
        _prompts.Add("What food did I ate that I find really delicious?");

        Random random = new Random();

        return _prompts[random.Next(_prompts.Count)];

    }
}