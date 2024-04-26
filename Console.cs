using System;
using System.IO;
using System.Collections.Generic;

class MadLibs
{
    static void Main()
    {
        PlayGame();
    }

    static void PlayGame()
    {

    }

    static void CreateTemplate()
    {
        Console.WriteLine("Enter template name:");
        string TemplateName = Console.ReadLine();
        Console.WriteLine("Enter the Mad Libs template:");
        string Template = Console.ReadLine();

        using (StreamWriter writer = File.AppendText(TemplateName))
        {
            writer.WriteLine(Template);
        }
        Console.WriteLine("Template saved successfully!");
    }
    static string LoadTemplate(string TemplateName)
    {

    }

    static string ParseTemplate()
    {

    }

    static string CollectWord()
    {

    }
    
    static void FillTemplate()
    {

    }
}