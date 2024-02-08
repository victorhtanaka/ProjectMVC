using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Models
{
    public class Funcao
    {
        private int _CodFuncao;
        private string? _NomeFuncao;
        private string? _DescricaoFuncao;


        [Key]
        public int CodFuncao {
            get{
                return _CodFuncao;
            }set{
                if (value < 1)
                {
                    throw new Exception("Erro ao tentar inserir um numero < 1 como CodFuncao");
                } else
                {
                    _CodFuncao = value;
                }
            }
        }

        [Required(ErrorMessage="O nome nao pode ser vazio.")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "O nome deve possuir no minimo 1 e no maximo 30 caracteres.")]
        public string? NomeFuncao {
            get{
                return _NomeFuncao;
            }set{
                if (value == null || value == "")
                {
                    throw new Exception("Erro ao tentar inserir um valor nulo ou vazio como NomeFuncao");
                } else
                {
                    _NomeFuncao = value;
                }
            }}

        [Required(ErrorMessage="A descrição nao pode ser vazia.")]
        [StringLength(150, MinimumLength = 1, ErrorMessage = "A descrição deve possuir no minimo 1 e no maximo 150 caracteres.")]
        public string? DescricaoFuncao {
            get{
                return _DescricaoFuncao;
            }set{
                if (value == null || value == "")
                {
                    throw new Exception("Erro ao tentar inserir um valor nulo ou vazio como DescricaoFuncao");
                } else
                {
                    _DescricaoFuncao = value;
                }
            }}
    }
}
