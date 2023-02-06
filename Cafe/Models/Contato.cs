using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe.Models
{
    [Table(name: "Contatos")]
    public class Contato
    {
        //[NotMapped] gerar lista
        public int Id { set; get; }

        [MaxLength(50)]
        public string Nome { set; get; }

        [MaxLength(100)]
        public string Email { set; get; }

        [MaxLength(14)]
        public string Celular { set; get; }

        // [key] chave primaria
        //[table(name:("contatos")]
    }
}
