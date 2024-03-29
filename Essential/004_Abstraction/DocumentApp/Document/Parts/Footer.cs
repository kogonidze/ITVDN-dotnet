﻿namespace DocumentApp.Parts;

class Footer : DocumentPart
{
    public override string Content 
    { 
        get
        {
            if (content != null)
                return content;
            else
                return "Нижний колонтитул отсутствует.";
        }
        set
        {
            content = value;
        }
    }

    public override void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(Content);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
