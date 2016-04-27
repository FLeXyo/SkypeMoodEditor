using SKYPE4COMLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SkypeMoodEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Skype s = new Skype();
            while (true)
            {
                Console.Write("Enter new mood message with tags (usable tags: <i>, <b>, <u>, <font>, <center>, <blink>, <a>): ");
                string msg = Console.ReadLine();
                s.CurrentUserProfile.MoodText = Regex.Replace(msg, @" <.*?> ", ""); //Remove tags";
                s.CurrentUserProfile.RichMoodText = msg;
            }
        }
    }
}
