using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProjectMVC.Models
{
    public class Funcionario
    {
        [Key]
        public int CodFuncionario { get; set; }

        [Required(ErrorMessage="O nome nao pode ser vazio.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O nome deve possuir no minimo 2 e no maximo 100 caracteres.")]
        public string? NomeFuncionario { get; set; }

        [Required(ErrorMessage="O cpf nao pode ser vazio.")]
        [StringLength(15, MinimumLength = 1, ErrorMessage = "O cpf deve possuir no minimo 1 e no maximo 15 caracteres.")]
        public string? CPFFuncionario { get; set; }

        [Required(ErrorMessage="O endereco nao pode ser vazio.")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "O endereço deve possuir no minimo 1 e no maximo 200 caracteres.")]
        public string? EndFuncionario { get; set; }

        [Required(ErrorMessage="O email nao pode ser vazio.")]
        [StringLength(150, MinimumLength = 1, ErrorMessage = "O email deve possuir no minimo 1 e no maximo 150 caracteres.")]
        public string? EmailFuncionario { get; set; }

        [Required(ErrorMessage="O telefone nao pode ser vazio.")]
        [StringLength(15, MinimumLength = 1, ErrorMessage = "O telefone deve possuir no minimo 1 e no maximo 15 caracteres.")]
        public string? TelFuncionario { get; set; }

        public DateOnly DataNasc { get; set; }

        public decimal SalarioFuncionario { get; set; }

        [ForeignKey("Filial")]
        public int FkFilialCodFilial { get; set; }

        [ForeignKey("Funcao")]
        public int FkFuncaoCodFuncao { get; set; }
        
    }
}