using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Models
{
    public class Cliente
    {
        [Key]
        public int CodCliente { get; set; }

        [Required(ErrorMessage="O nome nao pode ser vazio.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "A nome deve possuir no minimo 1 e no maximo 100 caracteres.")]
        public string? NomeCliente { get; set; }

        [Required(ErrorMessage="O cpf nao pode ser vazio.")]
        [StringLength(15, MinimumLength = 1, ErrorMessage = "A cpf deve possuir no minimo 1 e no maximo 15 caracteres.")]
        public string? CPFCliente { get; set; }

        [Required(ErrorMessage="O endereço nao pode ser vazio.")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "A endereço deve possuir no minimo 1 e no maximo 200 caracteres.")]
        public string? EndCliente { get; set; }

        [Required(ErrorMessage="O email nao pode ser vazio.")]
        [StringLength(150, MinimumLength = 1, ErrorMessage = "A email deve possuir no minimo 1 e no maximo 150 caracteres.")]
        public string? EmailCliente { get; set; }

        [Required(ErrorMessage="O telefone nao pode ser vazio.")]
        [StringLength(15, MinimumLength = 1, ErrorMessage = "O telefone deve possuir no minimo 1 e no maximo 15 caracteres.")]
        public string? TelCliente { get; set; }

        public DateOnly DataNasc { get; set; }
    }
}