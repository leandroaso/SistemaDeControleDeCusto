using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaDeControleDeCusto.Models
{
    public class Departamento
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        public virtual ICollection<Funcionario> Funcionarios { get; set; }
    }
}