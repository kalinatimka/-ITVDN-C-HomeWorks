﻿using System;

namespace Classes
{
    class Title : Part
    {
        public override string Content
        {
            protected get 
            {
                if (content != null)
                    return content;
                else
                    return "Заголовок отсутствует.";
            }
            set 
            {
                content = value; 
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
