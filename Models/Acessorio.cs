using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Models
{
    public class Acessorio
    {
        private int _CodAcessorio;
        private string? _NomeAcessorio;
        [Key]
        
        public int CodAcessorio {
            get{
                return _CodAcessorio;
            }set{
                if (value < 1)
                {
                    throw new Exception("Erro ao tentar inserir um numero < 1 como CodAcessorio");
                } else
                {
                    _CodAcessorio = value;
                }
            }}

        [Required(ErrorMessage="O nome do acessorio nao pode ser vazio.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O nome deve possuir no minimo 3 e no maximo 50 caracteres")]
        public string? NomeAcessorio {
            get{
                return _NomeAcessorio;
            }set{
                if (value == null || value == "")
                {
                    throw new Exception("Erro ao tentar inserir um valor nulo ou vazio como NomeAcessorio");
                } else
                {
                    _NomeAcessorio = value;
                }
            }}
    }
}