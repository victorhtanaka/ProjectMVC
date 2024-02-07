using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
    public class AcessorioCarro
    {
        private int _CodAcessorioCarro;
        [Key]
        public int CodAcessorioCarro {
            get{
                return _CodAcessorioCarro;
            }set{
                if (value < 1)
                {
                    throw new Exception("Erro ao tentar inserir um numero < 1 como CodAcessorioCarro");
                } else
                {
                    _CodAcessorioCarro = value;
                }
            }}
        [ForeignKey("Acessorio")]
        public int FkAcessorioCodAcessorio { get; set; }

        [ForeignKey("Carro")]
        public int FkCarroCodCarro { get; set; }
    }
}