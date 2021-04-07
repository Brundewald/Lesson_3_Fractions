using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;


namespace HomeWork3
{
    class GetStudentsData
    {
        public static void StudentsList(out List<string> listNames) 
        {            
            listNames = new List<string>();                       

            StreamReader sr = new StreamReader("students.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    listNames.Add(s[1] + " " + s[0]);
                    
                }
                catch { }
            }
            listNames.RemoveAt(0);
            sr.Close();         
        }

        public static void GetCourse(out List<int> listCourse)
        {
            int bach = 0;
            int mast = 0;
            listCourse = new List<int>();

            StreamReader sr = new StreamReader("students.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    listCourse.Add(int.Parse(s[6]));
                }
                catch { }
            }            
            sr.Close();
        }


    }
}
