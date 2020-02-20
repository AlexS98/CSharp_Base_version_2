using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public static class Extensions
    {
        public static void SetBackgroundColor(Season season)
        {
            switch (season)
            {
                case Season.Summer:
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    break;
                case Season.Winter:
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    break;
                case Season.Autumn:
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    break;
                case Season.Spring:
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    break;
                case Season.None:
                    break;

            }
        }
        public static void ToConsoleWrite(string str, ConsoleColor color = ConsoleColor.White, Season season = Season.None)
        {
            Console.ForegroundColor = color;
            SetBackgroundColor(season);
            Console.Write(str);
            Console.ResetColor();
        }

        public static void ToConsoleWrite(char str, ConsoleColor color = ConsoleColor.White, Season season = Season.None)
        {
            Console.ForegroundColor = color;
            SetBackgroundColor(season);
            Console.Write(str);
            Console.ResetColor();
        }

        public static void ToConsole(string str, ConsoleColor color = ConsoleColor.White, Season season = Season.None)
        {
            Console.ForegroundColor = color;
            SetBackgroundColor(season);
            Console.WriteLine(str);
            Console.ResetColor();
        }
    }
}
