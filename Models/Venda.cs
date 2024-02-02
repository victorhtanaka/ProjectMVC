using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
    public class Venda
    {
        [Key]
        public int CodVenda { get; set; }

        public DateOnly DataVenda { get; set; }

        public DateOnly UltimaRevisao { get; set; }

        [ForeignKey("Cliente")]
        public int FkClienteCodCliente { get; set; }

        [ForeignKey("Carro")]
        public int FkCarroCodCarro { get; set; }

        [ForeignKey("Funcionario")]
        public int FkFuncionarioCodFuncionario { get; set; }
    }
}