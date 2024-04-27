using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Bussiness_Application.Variables;


namespace Bussiness_Application.BL
{
    class Registered_Stu
    {
        private  Muser_BL o = new Muser_BL();
        private  string name;
        private  string rollno;
        private  string discipline;
        private  string age;
        private  string city;
        private  string session;
        public Registered_Stu(string username,string password, string name , string rollno,string discipline,string age,string city,string session)
        {
            O.Username = username;
            O.Password = password;
            Name = name;
            Rollno = rollno;
            Discipline = discipline;
            Age = age;
            City = city;
            Session = session;
            if (Class1.count == 1)
            {
                StreamWriter filevariable = new StreamWriter("Registered_Stu.txt", true);
                filevariable.WriteLine(O.Username + "," + O.Password + "," + Name + "," + Rollno + "," + Discipline + "," + Age + "," + City + "," + Session);
                filevariable.Flush();
                filevariable.Close();
            }
        }
        public Registered_Stu()
        {

        }        
        public  string Name { get => name; set => name = value; }
        public  string Rollno { get => rollno; set => rollno = value; }
        public  string Discipline { get => discipline; set => discipline = value; }
        public  string Age { get => age; set => age = value; }
        public  string City { get => city; set => city = value; }
        public  string Session { get => session; set => session = value; }
        public  Muser_BL O { get => o; set => o = value; }
    }
}
