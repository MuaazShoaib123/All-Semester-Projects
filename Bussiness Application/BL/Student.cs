using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Bussiness_Application.DL;

namespace Bussiness_Application.BL
{
    class Student
    {
        private string name;
        private string father;
        private float matricmarks;
        private string city;
        private string age;
        private string discipline;
        private float aggrigate;
       public Student(string name,string father,float matricmarks,string city,string age,string discipline,string path)
        {
            Name = name;
            Father = father;
            Matricmarks = matricmarks;
            City = city;
            Age = age;
            Discipline = discipline;
            Aggrigate = (Matricmarks / 1100) * 100;
            StreamWriter filevariable = new StreamWriter(path, true);
            filevariable.WriteLine(name + "," + father + "," + age + "," + matricmarks + "," + city + "," + discipline + "," + aggrigate);
            filevariable.Flush();
            filevariable.Close();
        }
        public Student()
        {

        }

        public  string Name { get => name; set => name = value; }
        public  string Father { get => father; set => father = value; }
        public  float Matricmarks { get => matricmarks; set => matricmarks = value; }
        public  string City { get => city; set => city = value; }
        public  string Age { get => age; set => age = value; }
        public  string Discipline { get => discipline; set => discipline = value; }
        public  float Aggrigate { get => aggrigate; set => aggrigate = value; }
    }
}
