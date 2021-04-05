using System;
using System.Collections.Generic;
using System.Text;

/*Created by Nikita Mialkin for GeekBrains*/

namespace Homework_2.cheks
{
    class charCheck
    {
        public static void GetWords(string mssg, int nmbbr, out List<string> words) 
        {

            string cw;
            char ch;
            StringBuilder nsb = new StringBuilder();
            words = new List<string> { };

            for (int i = 0; i <= mssg.Length - 1; i++)
            {
                ch = mssg[i];
                if (char.IsLetter(ch) == true)
                {
                    nsb = nsb.Append(ch);                    
                }
                else
                {
                    if (nsb.Length == nmbbr)
                    {                        
                        cw = nsb.ToString();
                        words.Add(cw);
                        nsb.Clear();
                    }
                    else nsb.Clear();
                }
            }
            if (nsb.Length == nmbbr)
            {
                cw = nsb.ToString();
                words.Add(cw);
                nsb.Clear();
            }
            
            Console.Write($"The words with {nmbbr} chars is: ");
            Console.Write(string.Join(", ", words.ToArray()));


        }
    }
}
