using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
    public class AcessorioCarro
    {
        [ForeignKey("Acessorio")]
        public int FkAcessorioCodAcessorio { get; set; }

        [ForeignKey("Carro")]
        public int FkCarroCodCarro { get; set; }
    }
}