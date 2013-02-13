using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DCS.Model[;

namespace DCS.Busines
{
    public class Userbl
    {
        private List<User> _users;

        public Userbl()
        {
        }

        public Userbl(List<User> users)
        {
            this._users = users;
        }
    }
}
