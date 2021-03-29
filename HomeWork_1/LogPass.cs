using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    class LogPass
    {
        
        public static void Start()
        {
            String log;
            String pass;
            Console.Write("\nEnter login: ");
            logPasCheck(out log, out pass);
            Console.WriteLine($"\nYour login {log} and password {pass}");
        }

        private static void logPasCheck(out string log, out string pass)
        {
            log = Console.ReadLine();
            int loglenght = log.Length;
            for (int i = 0; i <= log.Length; i++)
            {
                if (char.IsDigit(log, i) && i <= 1) { Console.WriteLine("Your login begins from digit."); break; }
                else { Console.WriteLine("All 'ok'"); break; }
            }
            switch (loglenght)
            {
                case <= 2: Console.WriteLine("Your login is too short."); break;
                case > 10: Console.WriteLine("Your login is too long."); break;
                default: Console.WriteLine(); break;
            }
            



            Console.Write("\nEnter password: ");
            pass = Console.ReadLine();

            int passlenght = pass.Length;
            for (int i = 0; i <= pass.Length; i++)
            {
                if (char.IsDigit(pass, i) && i <= 1) { Console.WriteLine("Your password begins from digit."); break; }
                else { Console.WriteLine("All 'ok'"); break; }
            }
            switch (passlenght)
            {
                case <= 2: Console.WriteLine("Your login is too short."); break;
                case > 10: Console.WriteLine("Your login is too long."); break;
                default: Console.WriteLine(); break;
            }
        }

    }
}
