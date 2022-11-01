using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voting.Enums;

namespace voting.models
{
    public class Student : Person
    {
        public string? MatricNo { get; set; }
        public string? Level { get; set; }
        public string? CGPA { get; set; }

        public Student(int id, string name, string email, string password, DateTime dateOfBirth, Gender gender,string? matricNo, string? level, string? cGPA) : base(id, name, email, password, dateOfBirth, gender)
        {
            MatricNo = matricNo;
            Level = level;
            CGPA = cGPA;
        }

        public override string ToString()
        {
            return $"{Id}\t{Name}\t{Email}\t{Password}\t{DateOfBirth}\t{Gender}\t{MatricNo}\t{Level}\t{CGPA}";
        }

        public static Student ToStudent(string str)
        {
            var student = str.Split('\t');

            var id = int.Parse(student[0]);
            var name = student[1];
            var email = student[2];
            var password = student[3];
            var dateOfBirth = DateTime.Parse(student[4]);
            var gender = (Gender) Enum.Parse(typeof(Gender), student[5]);
            var matricNo = student[6];
            var level = student[7];
            var cGPA = student[8];

            return new Student(id, name, email, password, dateOfBirth, gender, matricNo, level, cGPA);

        }

    }

    
}
