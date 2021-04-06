using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;


/*Created by Nikita Mialkin for GeekBrains*/

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStudents.StudentsData(out List<string> list);
            DataHandler.GetData(data: list);

        }
    }
}
