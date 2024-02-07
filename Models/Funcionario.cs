using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
    public class Funcionario
    {
        private int _CodFuncionario;
        private string? _NomeFuncionario;
        private string? _CPFFuncionario;
        private string? _EndFuncionario;
        private string? _EmailFuncionario;
        private string? _TelFuncionario;
        private DateOnly _DataNasc;
        private decimal _SalarioFuncionario;

        [Key]
        public int CodFuncionario {
            get{
                return _CodFuncionario;
            }set{
                if (value < 1)
                {
                    throw new Exception("Erro ao tentar inserir um numero < 1 como CodFuncionario");
                } else
                {
                    _CodFuncionario = value;
                }
            }}

        [Required(ErrorMessage="O nome nao pode ser vazio.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O nome deve possuir no minimo 2 e no maximo 100 caracteres.")]
        public string? NomeFuncionario {
            get{
                return _NomeFuncionario;
            }set{
                if (value == null || value == "")
                {
                    throw new Exception("Erro ao tentar inserir um valor nulo ou vazio como NomeFuncionario");
                } else
                {
                    _NomeFuncionario = value;
                }
            }}

        [Required(ErrorMessage="O cpf nao pode ser vazio.")]
        [StringLength(15, MinimumLength = 1, ErrorMessage = "O cpf deve possuir no minimo 1 e no maximo 15 caracteres.")]
        public string? CPFFuncionario {
            get{
                return _CPFFuncionario;
            }set{
                if (value == null || value == "")
                {
                    throw new Exception("Erro ao tentar inserir um valor nulo ou vazio como CPFFuncionario");
                } else
                {
                    _CPFFuncionario = value;
                }
            }}

        [Required(ErrorMessage="O endereco nao pode ser vazio.")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "O endereço deve possuir no minimo 1 e no maximo 200 caracteres.")]
        public string? EndFuncionario {
            get{
                return _EndFuncionario;
            }set{
                if (value == null || value == "")
                {
                    throw new Exception("Erro ao tentar inserir um valor nulo ou vazio como EndFuncionario");
                } else
                {
                    _EndFuncionario = value;
                }
            }}

        [Required(ErrorMessage="O email nao pode ser vazio.")]
        [StringLength(150, MinimumLength = 1, ErrorMessage = "O email deve possuir no minimo 1 e no maximo 150 caracteres.")]
        public string? EmailFuncionario {
            get{
                return _EmailFuncionario;
            }set{
                if (value == null || value == "")
                {
                    throw new Exception("Erro ao tentar inserir um valor nulo ou vazio como EmailFuncionario");
                } else
                {
                    _EmailFuncionario = value;
                }
            }}

        [Required(ErrorMessage="O telefone nao pode ser vazio.")]
        [StringLength(15, MinimumLength = 1, ErrorMessage = "O telefone deve possuir no minimo 1 e no maximo 15 caracteres.")]
        public string? TelFuncionario {
            get{
                return _TelFuncionario;
            }set{
                if (value == null || value == "")
                {
                    throw new Exception("Erro ao tentar inserir um valor nulo ou vazio como TelFuncionario");
                } else
                {
                    _TelFuncionario = value;
                }
            }}

        public DateOnly DataNasc {
            get{
                return _DataNasc;
            }set{
                if (DateTime.Now.Year - value.Year > 130 || DateTime.Now.Year - value.Year < 0)
                {
                    throw new Exception("Erro ao tentar inserir uma data invalida como DataNasc");
                } else
                {
                    _DataNasc = value;
                } 
            }}

        [Required(ErrorMessage="O salario nao pode ser vazio")]
        [Range(0, 99999999.99, ErrorMessage="O salario deve ser entre 0 e 99999999.99.")]
        public decimal SalarioFuncionario {
            get{
                return _SalarioFuncionario;
            }set{
                if (value < 0)
                {
                    throw new Exception("Erro ao tentar inserir um numero negativo como SalarioFuncionario");
                } else
                {
                    _SalarioFuncionario = value;
                }
            }}

        [ForeignKey("Filial")]
        public int FkFilialCodFilial { get; set; }

        [ForeignKey("Funcao")]
        public int FkFuncaoCodFuncao { get; set; }
        
    }
}