﻿using System;
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Academy of Learning Career Collage");
        Console.WriteLine("Student Daily Raport");
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Whar course are you on?");
        string course = Console.ReadLine();
        Console.WriteLine("What page number?");
        int pageNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
        string needHelp = Console.ReadLine();
        bool needHelpBool = bool.Parse(needHelp);
        Console.WriteLine("Were there are positive experiences you'd like to share? Please give specifics.");
        string positiveExperiences = Console.ReadLine();
        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
        string feedback = Console.ReadLine();
        Console.WriteLine("How many hours did you study today?");
        string studyHours = Console.ReadLine();
        int studyHoursNum = Convert.ToInt32(studyHours);
        Console.WriteLine("Thank you for your answers. An instructor will respons to this shortly. Have a great day!");
        Console.ReadLine();
        }
    }
