using System;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Address eventAddress1 = new Address("7th Ave", "New York", "NY", "USA");
        Address eventAddress2 = new Address("Tindale St", "General Santos City", "South Cotabato", "PH");
        Address eventAddress3 = new Address("123 Tulip Drive", "London", "England", "UK");
        
        Lecture lecture = new Lecture("Innovate and Protect Your Software IP in a Competitive Market!", "Learn how to fortify your software IP with expert strategies and firsthand success stories from top technology disruptors!", "June 27, 2024", "1:15PM PST", eventAddress1,"Gearheart Law",550);
        Reception reception = new Reception("Wedding","Wedding of Florante & Laura","June 12, 2024","3:00PM",eventAddress2,"justmarried@gmail.com.ph");
        Outdoor outdoor = new Outdoor("White Water Rafting", "White water rafting in the River of Babylon", "July 4, 2024", "9:30AM", eventAddress3,"Partly Cloudy, Chance of Rain is 40%");

        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetLectureDetails());
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetReceptionDetails());
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine(outdoor.GetOutdoorDetails());
        Console.WriteLine(outdoor.GetShortDescription());
    }
}