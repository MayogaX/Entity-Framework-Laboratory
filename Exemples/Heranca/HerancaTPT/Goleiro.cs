using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaTPT
{
    [Table("Goleiros")]
    public class Goleiro : Jogador
    {
        public int GolsDefendidos { get; set; }

        public void FazPeixinho()
        {
        }
    }
}
