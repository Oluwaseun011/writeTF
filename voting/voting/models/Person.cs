using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voting.Enums;

namespace voting.models
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Role Role { get; set; }


        public Person(int id, string name, string email, string password, DateTime dateOfBirth, Gender gender)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }
    }
}
