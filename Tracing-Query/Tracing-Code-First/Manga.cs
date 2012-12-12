using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tracing_Code_First
{
    public class Manga
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Mangaka { get; set; }
        public DateTime Lancamento { get; set; }
    }
}
