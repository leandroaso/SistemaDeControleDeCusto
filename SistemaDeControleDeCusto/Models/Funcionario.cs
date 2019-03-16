using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeControleDeCusto.Models
{
    public class Funcionario
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(200)]
        public string Nome { get; set; }

        public int[] DepartamentosID { get; set; }
        public ICollection<Departamento> Departamentos { get; set; }

        [NotMapped]
        public string DepartamentosFormatados
        {
            get
            {
                var departamentos = string.Empty;
                if (Departamentos == null)
                    return string.Empty;

                foreach (var departamento in Departamentos)
                {
                    departamentos += $" {departamento.Nome},";
                }

                if (string.IsNullOrWhiteSpace(departamentos))
                    return string.Empty;

                departamentos = departamentos.Substring(0, departamentos.Length - 1);
                return departamentos; 
            }
        }
    }
}