using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaTPT
{
    [Table("Artilheiro")]
    public class Artilheiro : Jogador
    {
        public int GolsMarcados { get; set; }

        public void MarcarGol()
        {
        }
    }
}
