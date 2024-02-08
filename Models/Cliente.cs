using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Models
{
    public class Cliente
    {
        private int _CodCliente;
        private string? _NomeCliente;
        private string? _CPFCliente;
        private string? _EndCliente;
        private string? _EmailCliente;
        private string? _TelCliente;
        private DateOnly _DataNasc;

        [Key]
        public int CodCliente {
            get{
                return _CodCliente;
            }set{
                if (value < 1)
                {
                    throw new Exception("Erro ao tentar inserir um numero < 1 como CodCliente");
                } else
                {
                    _CodCliente = value;
                }
            }}

        [Required(ErrorMessage="O nome nao pode ser vazio.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "A nome deve possuir no minimo 1 e no maximo 100 caracteres.")]
        public string? NomeCliente { get; set;}
            /*get{
                return _NomeCliente;
            }set{
                if (value == null || value == "")
                {
                    throw new Exception("Erro ao tentar inserir um valor nulo ou vazio como NomeCliente");
                } else
                {
                    _NomeCliente = value;
                }
            }}*/

        [Required(ErrorMessage="O cpf nao pode ser vazio.")]
        [StringLength(15, MinimumLength = 1, ErrorMessage = "A cpf deve possuir no minimo 1 e no maximo 15 caracteres.")]
        public string? CPFCliente {
            get{
                return _CPFCliente;
            }set{
                if (value == null || value == "")
                {
                    throw new Exception("Erro ao tentar inserir um valor nulo ou vazio como CPFCliente");
                } else
                {
                    _CPFCliente = value;
                }
            }}

        [Required(ErrorMessage="O endereço nao pode ser vazio.")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "A endereço deve possuir no minimo 1 e no maximo 200 caracteres.")]
        public string? EndCliente {
            get{
                return _EndCliente;
            }set{
                if (value == null || value == "")
                {
                    throw new Exception("Erro ao tentar inserir um valor nulo ou vazio como EndCliente");
                } else
                {
                    _EndCliente = value;
                }
            }}

        [Required(ErrorMessage="O email nao pode ser vazio.")]
        [StringLength(150, MinimumLength = 1, ErrorMessage = "A email deve possuir no minimo 1 e no maximo 150 caracteres.")]
        public string? EmailCliente {
            get{
                return _EmailCliente;
            }set{
                if (value == null || value == "")
                {
                    throw new Exception("Erro ao tentar inserir um valor nulo ou vazio como EmailCliente");
                } else
                {
                    _EmailCliente = value;
                }
            }}

        [Required(ErrorMessage="O telefone nao pode ser vazio.")]
        [StringLength(15, MinimumLength = 1, ErrorMessage = "O telefone deve possuir no minimo 1 e no maximo 15 caracteres.")]
        public string? TelCliente {
            get{
                return _TelCliente;
            }set{
                if (value == null || value == "")
                {
                    throw new Exception("Erro ao tentar inserir um valor nulo ou vazio como TelCliente");
                } else
                {
                    _TelCliente = value;
                }
            }}

        public DateOnly DataNasc {
            get{
                return _DataNasc;
            }set{
                if (DateTime.Now.Year - value.Year > 130 || DateTime.Now.Year - value.Year <= 0)
                {
                    throw new Exception("Erro ao tentar inserir uma data passada como DataNasc");
                } else
                {
                    _DataNasc = value;
                } 
            }}
    }
}