using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bussiness_Application.BL
{
    class Exam_BL
    {
        private int english;
        private int urdu;
        private int physics;
        private int chemistry;
        private int mbc;
        private int total;
        private int islamiat;
        private Registered_Stu o = new Registered_Stu();
        
        public Exam_BL(string rollno,int english,int urdu,int physics,int chemistry,int mbc,int islamiat)
        {
            O.Rollno = rollno;
            English = english;
            Urdu = urdu;
            Physics = physics;
            Chemistry = chemistry;
            Mbc = mbc;
            Islamiat = islamiat;
            Total = english + urdu + physics + chemistry + mbc + islamiat;
            StreamWriter filevariable = new StreamWriter("Stu_Exam.txt", true);
            filevariable.WriteLine(O.Rollno + "," + English + "," + Urdu + "," + Physics + "," + Chemistry + "," + Mbc + "," + Islamiat + "," + Total);
            filevariable.Flush();
            filevariable.Close();
        }
        public Exam_BL()
        {

        }

        public int English { get => english; set => english = value; }
        public int Urdu { get => urdu; set => urdu = value; }
        public int Physics { get => physics; set => physics = value; }
        public int Chemistry { get => chemistry; set => chemistry = value; }
        public int Mbc { get => mbc; set => mbc = value; }
        public int Islamiat { get => islamiat; set => islamiat = value; }
        public Registered_Stu O { get => o; set => o = value; }
        public int Total { get => total; set => total = value; }
    }
}
