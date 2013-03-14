using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unusua_Types
{
    public class Manga
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Column(TypeName = "smallDateTime")]
        public DateTime Date { get; set; }
    }
}
