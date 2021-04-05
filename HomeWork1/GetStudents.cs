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
           

            StreamReader sr = new StreamReader("C:\\Users\\nsm\\source\\repos\\Lesson_3_Fractions\\students.csv");
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
            }
            sr.Close();
            list.Sort();
            foreach (var v in list) 
            {
                Console.WriteLine(v);
            }
        }
        

    }
}
