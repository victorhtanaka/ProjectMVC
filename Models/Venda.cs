using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
    public class Venda
    {
        private int _CodVenda;
        private DateOnly _DataVenda;
        private DateOnly _UltimaRevisao;

        [Key]
        public int CodVenda {
            get{
                return _CodVenda;
            }set{
                if (value < 1)
                {
                    throw new Exception("Erro ao tentar inserir um numero < 1 como CodVenda");
                } else
                {
                    _CodVenda = value;
                }
            }}

        public DateOnly DataVenda {
            get{
                return _DataVenda;
            }set{
                if (DateTime.Now.Year - value.Year < 0)
                {
                    throw new Exception("Erro ao tentar inserir uma data invalida como DataVenda");
                } else
                {
                    _DataVenda = value;
                } 
            }}

        public DateOnly UltimaRevisao {
            get{
                return _UltimaRevisao;
            }set{
                if (DateTime.Now.Year - value.Year < 0)
                {
                    throw new Exception("Erro ao tentar inserir uma data invalida como UltimaRevisao");
                } else
                {
                    _UltimaRevisao = value;
                } 
            }}

        [ForeignKey("Cliente")]
        public int FkClienteCodCliente { get; set; }

        [ForeignKey("Carro")]
        public int FkCarroCodCarro { get; set; }

        [ForeignKey("Funcionario")]
        public int FkFuncionarioCodFuncionario { get; set; }
    }
}