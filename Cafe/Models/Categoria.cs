using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe.Models
{
    [Table(name:"Categorias")]
    public class Categoria
    {
        public int Id { set; get; }

        [MaxLength(50)]
        [Required]
        public string Nome { set; get; }

        public virtual ICollection<Alimento> Alimentos { set; get; }
    }
}
