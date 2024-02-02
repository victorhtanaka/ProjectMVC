using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
    public class Funcao
    {
        [Key]
        public int CodFuncao { get; set; }

        [Required]
        [StringLength(30)]
        public string? NomeFuncao { get; set; }

        [StringLength(150)]
        public string? DescricaoFuncao { get; set; }
    }
}
