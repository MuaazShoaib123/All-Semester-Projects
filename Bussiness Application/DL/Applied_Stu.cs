using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness_Application.BL;
using System.IO;

namespace Bussiness_Application.DL
{
    class Applied_Stu
    { 
        public  static string path = "Applied_Stu.txt";
        private static List<Student> applied_stu = new List<Student>();
        public static List<Student> Applied_stu { get => applied_stu; set => applied_stu = value; }

        public static void readdata()
        {
            StreamReader fileVariable = new StreamReader(path);
            string record;
            while ((record = fileVariable.ReadLine()) != null)
            {
                Student s = new Student();
                s.Name = Parsedata(record, 1);
                s.Father = Parsedata(record, 2);
                s.Age = Parsedata(record, 3);
                s.Matricmarks = int.Parse(Parsedata(record, 4));
                s.City = Parsedata(record, 5);
                s.Discipline = Parsedata(record, 6);
                s.Aggrigate = float.Parse(Parsedata(record, 7));
                Applied_stu.Add(s);
            }
            fileVariable.Close();
        }
        public static string Parsedata(string record, int field)
        {
            int commaCount = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    commaCount = commaCount + 1;
                }
                else if (commaCount == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
            
        
    }
}

