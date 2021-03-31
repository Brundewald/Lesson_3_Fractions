using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_2
{
    class Message
    {
        public static void Start()
        {
            string msg;
            int nmbr;
            StringBuilder nsb = new StringBuilder();
            char ch;
            int count = 0;
            string[] word = new string [count];
            string cw;            
            getData(out msg, out nmbr);
            for (int i = 0; i <= msg.Length - 1; i++)
            {
                ch = msg[i];
                if (char.IsLetter(ch) == true)
                {
                    nsb = nsb.Append(ch);
                    Console.WriteLine(ch);
                    Console.WriteLine(nsb);
                }
                else
                {
                    if (nsb.Length == nmbr)
                    {
                        count++;
                        cw = nsb.ToString();
                        word[count-1] = cw;
                        nsb.Clear();
                    }
                    else nsb.Clear();
                }
            }
            if (nsb.Length == nmbr)
            {
                count++;
                cw = nsb.ToString();
                word[count-1] = cw;
                nsb.Clear();
            }
            Console.Write(word.ToString());
        }

        private static void getData(out string msg, out int nmbr)
        {
            Console.WriteLine("This program can read your message.\nFirst enter your message, and after enter a number.\n");
            msg = Console.ReadLine();
            Console.Write($"\nMessage: {msg}\n");

            nmbr = Convert.ToInt32(Console.ReadLine());
            Console.Write($"\nNumber: {nmbr}\n");
        }
    }
}
