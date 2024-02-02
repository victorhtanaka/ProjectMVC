using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
    public class Funcionario
    {
        [Key]
        public int CodFuncionario { get; set; }

        [Required]
        [StringLength(100)]
        public string NomeFuncionario { get; set; }

        [StringLength(15)]
        public string CPFFuncionario { get; set; }

        [StringLength(200)]
        public string EndFuncionario { get; set; }

        [StringLength(150)]
        public string EmailFuncionario { get; set; }

        [StringLength(15)]
        public string TelFuncionario { get; set; }

        public DateOnly DataNasc { get; set; }

        public decimal SalarioFuncionario { get; set; }

        [ForeignKey("Filial")]
        public int FkFilialCodFilial { get; set; }

        [ForeignKey("Funcao")]
        public int FkFuncaoCodFuncao { get; set; }
    }
}