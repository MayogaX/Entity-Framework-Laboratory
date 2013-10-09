using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaTPT
{
    [Table("Jogadores")]
    public class Jogador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
