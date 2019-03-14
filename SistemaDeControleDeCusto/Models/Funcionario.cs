using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaDeControleDeCusto.Models
{
    public class Funcionario
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(200)]
        public string Nome { get; set; }

        [Required]
        public ICollection<Departamento> Departamentos { get; set; }
    }
}