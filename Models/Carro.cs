using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProjectMVC.Models
{
    public class Carro
    {
        [Key]
        public int CodCarro { get; set; }

        [Required(ErrorMessage="O numero do chassi não pode ser vazio.")]
        [StringLength(17, MinimumLength = 17, ErrorMessage = "O numero do chassi deve possuir 7 caracteres.")]
        public string? NumChassi { get; set; }

        [Required(ErrorMessage="O modelo nao pode ser vazio.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "O modelo deve possuir no minimo 1 e no maximo 50 caracteres.")]
        public string? ModeloCarro { get; set; }

        [Required(ErrorMessage="A marca nao pode ser vazio.")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "A marca deve possuir no minimo 1 e no maximo 30 caracteres.")]
        public string? MarcaCarro { get; set; }

        [Required(ErrorMessage="O ano deve ter 4 numeros")]
        [Range(1, 9999, ErrorMessage="O ano deve ter 4 numeros de 1000 ate 9999.")]  
        public int AnoCarro { get; set; }

        [Required(ErrorMessage="A cor do carro nao pode ser vazia.")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "A cor deve possuir no minimo 1 e no maximo 20 caracteres.")]
        public string? CorCarro { get; set; }

        [Required(ErrorMessage="O valor nao pode ser vazio")]
        [Range(0, 999999999.99, ErrorMessage="O valor deve ser entre 0 e 999999999,99.")]  
        public decimal ValorCarro { get; set; }

        [Required(ErrorMessage="A quilometragem nao pode ser vazia")]
        [Range(0, 999999999.99, ErrorMessage="A quilometragem deve ser entre 0 e 999999999,99.")]  
        public float KmCarro { get; set; }

        [ForeignKey("Filial")]
        public int FkFilialCodFilial { get; set; }
    }
}