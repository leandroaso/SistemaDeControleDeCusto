using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace SistemaDeControleDeCusto.Models
{
    public class Movimentacao
    {
        public int ID { get; set; }

        public int FuncionarioID { get; set; }

        [Required]
        [MaxLength(500)]
        public string Descricao { get; set; }

        public virtual Funcionario  Funcionario{ get; set; }
    }
}