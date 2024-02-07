using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
    public class Agenda
    {
        private int _CodAgenda;
        private DateTime _DataAgenda;
        private string? _Modelo;
        private int _Ano;
        private float _Km;

        [Key]
        public int CodAgenda {
            get{
                return _CodAgenda;
            }set{
                if (value < 1)
                {
                    throw new Exception("Erro ao tentar inserir um numero < 1 como CodAgenda");
                } else
                {
                    _CodAgenda = value;
                } 
            }}

        public DateTime DataAgenda {
            get{
                return _DataAgenda;
            }set{
                if (value < DateTime.Now)
                {
                    throw new Exception("Erro ao tentar inserir uma data passada como DataAgenda");
                } else
                {
                    _DataAgenda = value;
                } 
            }}

        [Required(ErrorMessage="O modelo nao pode ser vazio.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "O modelo deve possuir no minimo 1 e no maximo 50 caracteres.")]
        public string? Modelo {
            get{
                return _Modelo;
            }set{
                if (value == null || value == "")
                {
                    throw new Exception("Erro ao tentar inserir um valor nulo ou vazio como Modelo");
                } else
                {
                    _Modelo = value;
                }
            }}

        [Required(ErrorMessage="O ano nao pode ser vazio.")]
        [Range(4, 4, ErrorMessage="O ano deve ter 4 numeros.")]  
        public int Ano {
            get{
                return _Ano;
            }set{
                if (value > DateTime.Now.Year + 2)
                {
                    throw new Exception("Erro ao tentar inserir um valor muito alto como Ano");
                } else
                {
                    _Ano = value;
                } 
            }}

        [Required(ErrorMessage="A quilometragem nao pode ser vazia")]
        [Range(1, 99999999.99, ErrorMessage="O ano deve ter 4 numeros.")]  
        public float Km {
            get{
                return _Km;
            }set{
                if (value < 0)
                {
                    throw new Exception("Erro ao tentar inserir um valor negativo em Km");
                } else
                {
                    _Km = value;
                } 
            }}

        [ForeignKey("Funcionario")]
        public int FkFuncionarioCodFuncionario { get; set; }

        [ForeignKey("Servico")]
        public int FkServicoCodServico { get; set; }

        [ForeignKey("Cliente")]
        public int FkClienteCodCliente { get; set; }
    }
}