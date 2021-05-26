using System;
using System.Collections.Generic;
using System.Text;
using Homework_2.dataGet;
using Homework_2.cheks;

/*Created by Nikita Mialkin for GeekBrains*/

namespace Homework_2
{
    class Message
    {
        public static void Start()
        {
            data.getData(out string msg, out int nmbr);
            charCheck.GetWords(mssg: msg, nmbbr: nmbr, out List<string> words);
            Console.Write(words.ToString());
        }

        
    }
}
