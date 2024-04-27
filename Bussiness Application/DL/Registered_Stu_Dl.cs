using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness_Application.BL;
using System.IO;

namespace Bussiness_Application.DL
{
    class Registered_Stu_Dl
    {
        private static List<Registered_Stu> registeredstu = new List<Registered_Stu>();

        public static List<Registered_Stu> Registeredstu { get => registeredstu; set => registeredstu = value; }

        public static void addtolist(Registered_Stu s)
        {
            Registeredstu.Add(s);
        }
        public static void readdata()
        {
            StreamReader fileVariable = new StreamReader("Registered_Stu.txt");
            string record;
            while ((record = fileVariable.ReadLine()) != null)
            {
                Registered_Stu s = new Registered_Stu();
                s.O.Username = Parsedata(record, 1);
                s.O.Password = Parsedata(record, 2);
                s.Name = Parsedata(record, 3);
                s.Rollno = Parsedata(record, 4);
                s.Discipline = Parsedata(record, 5);
                s.Age = Parsedata(record, 6);
                s.City = Parsedata(record, 7);
                s.Session = Parsedata(record, 8);
                Registeredstu.Add(s);
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
        public static bool checkuser(string username, string password)
        {
            bool flag = false;
            for (int x = 0; x < Registeredstu.Count; x = x + 1)
            {
                if (username == Registeredstu[x].O.Username && password == Registeredstu[x].O.Password)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public static void deleteuser(Registered_Stu user)
        {
            for (int s = 0; s < Registeredstu.Count; s = s + 1)
            {
                if (user.O.Username == Registeredstu[s].O.Username && user.O.Password == Registeredstu[s].O.Password && user.Name == Registeredstu[s].Name && user.Rollno == Registeredstu[s].Rollno && user.Discipline == Registeredstu[s].Discipline && user.Session == Registeredstu[s].Session && user.Age == Registeredstu[s].Age && user.City == Registeredstu[s].City)
                {
                    Registeredstu.RemoveAt(s);
                }
            }
        }
        public static void storeinfile()
        {
            StreamWriter filevariable = new StreamWriter("Registered_Stu.txt");
            foreach (Registered_Stu s in Registeredstu)
            {
                filevariable.WriteLine(s.O.Username + "," + s.O.Password + "," + s.Name + "," + s.Rollno + "," + s.Discipline + "," + s.Age + "," + s.City + "," + s.Session);
            }
            filevariable.Flush();
            filevariable.Close();
        }

        public static void edituser(Registered_Stu previous, Registered_Stu updated)
        {
            foreach (Registered_Stu s in Registeredstu)
            {
                if (s.O.Username == previous.O.Username && s.O.Password == previous.O.Password && s.Name == previous.Name && s.Rollno == previous.Rollno && s.Discipline == previous.Discipline && s.Session == previous.Session && s.Age == previous.Age && s.City == previous.City)
                {
                    s.O.Username = updated.O.Username;
                    s.O.Password = updated.O.Password;
                    s.Name = updated.Name;
                    s.Rollno = updated.Rollno;
                    s.Discipline = updated.Discipline;
                    s.Age = updated.Age;
                    s.City = updated.City;
                    s.Session = updated.Session;
                }
            }

        }
    }
}

