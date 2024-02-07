using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
    public class Servico
    {
        public int CodServico;
        public string? NomeServico;
        public string? DescServico;

        [Key]
        public int _CodServico {
            get{
                return _CodServico;
            }set{
                if (value < 1)
                {
                    throw new Exception("Erro ao tentar inserir um numero < 1 como CodServico");
                } else
                {
                    _CodServico = value;
                }
            }}

        [Required(ErrorMessage="O nome do serviço nao pode ser vazio.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "O nome do serviço deve possuir no minimo 1 e no maximo 50 caracteres.")]
        public string? _NomeServico {
            get{
                return _NomeServico;
            }set{
                if (value == null || value == "")
                {
                    throw new Exception("Erro ao tentar inserir um valor nulo ou vazio como NomeServico");
                } else
                {
                    _NomeServico = value;
                }
            }}

        [Required(ErrorMessage="A descrição nao pode ser vazia.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "A descrição deve possuir no minimo 1 e no maximo 100 caracteres.")]
        public string? _DescServico {
            get{
                return _DescServico;
            }set{
                if (value == null || value == "")
                {
                    throw new Exception("Erro ao tentar inserir um valor nulo ou vazio como DescServico");
                } else
                {
                    _DescServico = value;
                }
            }}
        
    }
}