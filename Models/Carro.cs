using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
    public class Carro
    {
        [Key]
        public int CodCarro { get; set; }

        [Required]
        [StringLength(18)]
        public string? NumChassi { get; set; }

        [Required]
        [StringLength(50)]
        public string? ModeloCarro { get; set; }

        [StringLength(30)]
        public string? MarcaCarro { get; set; }

        public int AnoCarro { get; set; }

        [StringLength(20)]
        public string? CorCarro { get; set; }

        public decimal ValorCarro { get; set; }

        public float KmCarro { get; set; }

        [ForeignKey("Filial")]
        public int FkFilialCodFilial { get; set; }
    }
}