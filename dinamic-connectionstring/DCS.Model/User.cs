using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DCS.Model
{
    public class User
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Login { get; set; }
        public String Passaword { get; set; }

        public User(string name, string login, string passaword)
        {
            this.Id = new Guid();
            this.Name = name;
            this.Login = login;
            this.Passaword = passaword;
        }
    }
}
