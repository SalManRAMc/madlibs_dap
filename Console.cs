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
    Console.WriteLine("Enter the Mad Libs template:");
    string template = Console.ReadLine();
    using (StreamWriter writer = File.AppendText("madlibs_templates.txt"))
    {
       writer.WriteLine(template);
    }
    Console.WriteLine("Template saved successfully!");
    }
}

```