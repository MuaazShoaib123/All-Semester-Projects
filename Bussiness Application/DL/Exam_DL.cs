using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness_Application.BL;
using System.IO;

namespace Bussiness_Application.DL
{
    class Exam_DL
    {
        private static List<Exam_BL> result = new List<Exam_BL>();
        public static  void addtolist(Exam_BL e)
        {
            Result.Add(e);
        }
        public static void readdata()
        {
            StreamReader fileVariable = new StreamReader("Stu_Exam.txt");
            string record;
            while ((record = fileVariable.ReadLine()) != null)
            {
                Exam_BL e = new Exam_BL();
                e.O.Rollno = Parsedata(record, 1);
                e.English = int.Parse(Parsedata(record, 2));
                e.Urdu = int.Parse(Parsedata(record, 3));
                e.Physics = int.Parse(Parsedata(record, 4));
                e.Chemistry = int.Parse(Parsedata(record, 5));
                e.Mbc = int.Parse(Parsedata(record, 6));
                e.Islamiat = int.Parse(Parsedata(record, 7));
                e.Total = int.Parse(Parsedata(record, 8));
                result.Add(e);
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
        public static  List<Exam_BL> Result { get => result; set => result = value; }
    }
}
