using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp
{
    internal class User
    {
        private UInt16 Id { get; set; }
        private string Name { get; set; }
        private string Surname { get; set; }
        private string Email { get; set; }
        private DateTime CreatedAt { get; set; }

        public User(string name, string surname, string email)
        {
            Id += 1;
            Name = name;
            Surname = surname;
            Email = email;
            CreatedAt = DateTime.Now;
        }

        public void Display()
        {
            Console.WriteLine($"user: {Id}, {Name}, {Surname}, {Email}, {CreatedAt}"); 
        }

        public UInt16 IdFormat()
        {
            return Id; //Todo: auto increment
        }

        public string CreatedAtFormat()
        {
            return "Format"; //Todo: date format + static date value on instance
        }
    }
}
