using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;


namespace HomeWork3
{
    class GetStudents
    {
        public static void StudentsData() 
        {
            int bach = 0;
            int mast = 0;

            ArrayList list = new ArrayList();
           

            StreamReader sr = new StreamReader("students.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    list.Add(s[1] + " " + s[0]);
                    if (int.Parse(s[6]) < 6) bach++;
                    else mast++;

                }
                catch { }
                //{
                //    Console.WriteLine("Can't read from file");
                //    Console.WriteLine(e);
                //}
            }
            sr.Close();
            list.Sort();
            Console.WriteLine($"Bachelors: {bach}\nMasters: {mast}\n");
            foreach (var v in list) 
            {
                Console.WriteLine(v);
            }
        }
        

    }
}
