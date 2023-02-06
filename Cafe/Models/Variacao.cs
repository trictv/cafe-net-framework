using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe.Models
{
    [Table(name: "Variacoes")]
    public class Variacao
    {
        public int Id { set; get; }

        [MaxLength(50)]
        public string Nome { set; get; }

        public float Valor { set; get; }

        public virtual Alimento Alimento { set; get; }
    }
}
