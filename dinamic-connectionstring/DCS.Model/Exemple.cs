using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DCS.Model
{
    public class Exemple
    {
        public Guid Id { get; set; }
        public String Title { get; set; }
        public User User { get; set; }

        public Exemple(String title)
        {
            this.Title = title;
            this.Id = new Guid();
        }
    }
}
