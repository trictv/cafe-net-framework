using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe.Models
{
    [Table(name: "Alimentos")]
    public class Alimento
    {
        public int Id { set; get; }

        [MaxLength(50)]
        public string Nome { set; get; }

        [MaxLength(150)]
        public string Descricao { set; get; }
        public virtual Categoria Categoria { set; get; }

        public virtual ICollection<Variacao> Variacoes { set; get; }
    }
}
