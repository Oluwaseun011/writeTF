using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voting.Enums;

namespace voting.models
{
    public class Admin : Person
    {

        public Admin(int id, string name, string email, string password, DateTime dateOfBirth, Gender gender) : base(id, name, email, password, dateOfBirth, gender)
        {

        }

        public override string ToString()
        {
            return $"{Id}\t{Name}\t{Email}\t{Password}\t{DateOfBirth}\t{Gender}";
        }

        public static Admin ToAdmin(string str)
        {
            var admin = str.Split('\t');
            var id = int.Parse(admin[0]);
            var name = admin[1];
            var email = admin[2];
            var password = admin[3];
            var dateOfBirth = DateTime.Parse(admin[4]);
            Gender gender = (Gender)Enum.Parse(typeof(Gender), admin[5]);

            return new Admin(id, name, email, password, dateOfBirth, gender);
        }
    }
}
