using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    [Table(name: "Associado" , Schema = "dbo")]
    public class Associado
    {
        [Key]
        public Int64 IdAssociado { get; set; }

        public string Nome { get; set; }
    }
}
