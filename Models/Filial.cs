using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Models
{
    public class Filial
    {

        private int _CodFilial;
        private string? _NomeFilial;
        private string? _EndFilial;
        private string? _TelFilial;
        [Key]
        public int CodFilial {
            get{
                return _CodFilial;
            }set{
                if (value < 1)
                {
                    throw new Exception("Erro ao tentar inserir um numero < 1 como CodCarro");
                } else
                {
                    _CodFilial = value;
                }
            }}

        [Required(ErrorMessage="O nome nao pode ser vazio.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "O nome deve possuir no minimo 1 e no maximo 100 caracteres.")]
        public string? NomeFilial {
            get{
                return _NomeFilial;
            }set{
                if (value == null || value == "")
                {
                    throw new Exception("Erro ao tentar inserir um valor nulo ou vazio como NomeFilial");
                } else
                {
                    _NomeFilial = value;
                }
            }}

        [Required(ErrorMessage="O endereço nao pode ser vazio.")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "O endereço deve possuir no minimo 1 e no maximo 200 caracteres.")]
        public string? EndFilial {
            get{
                return _EndFilial;
            }set{
                if (value == null || value == "")
                {
                    throw new Exception("Erro ao tentar inserir um valor nulo ou vazio como EndFilial");
                } else
                {
                    _EndFilial = value;
                }
            }}

        [Required(ErrorMessage="O telefone nao pode ser vazio.")]
        [StringLength(15, MinimumLength = 1, ErrorMessage = "O telefone deve possuir no minimo 1 e no maximo 15 caracteres.")]
        public string? TelFilial {
            get{
                return _TelFilial;
            }set{
                if (value == null || value == "")
                {
                    throw new Exception("Erro ao tentar inserir um valor nulo ou vazio como TelFilial");
                } else
                {
                    _TelFilial = value;
                }
            }}
    }
}