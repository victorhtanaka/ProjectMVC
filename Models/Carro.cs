using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProjectMVC.Models
{
    public class Carro
    {
        private int _CodCarro;
        private string? _NumChassi;
        private string? _ModeloCarro;
        private string? _MarcaCarro;
        private int _AnoCarro;
        private string? _CorCarro;
        private decimal _ValorCarro;
        private float _KmCarro;

        [Key]
        public int CodCarro {
            get{
                return _CodCarro;
            }set{
                if (value < 1)
                {
                    throw new Exception("Erro ao tentar inserir um numero < 1 como CodCarro");
                } else
                {
                    _CodCarro = value;
                }
            }}

        [Required(ErrorMessage="O numero do chassi não pode ser vazio.")]
        [StringLength(17, MinimumLength = 17, ErrorMessage = "O numero do chassi deve possuir 7 caracteres.")]
        public string? NumChassi {
            get{
                return _NumChassi;
            }set{
                if (value == null || value == "")
                {
                    throw new Exception("Erro ao tentar inserir um valor nulo ou vazio como NumChassi");
                } else
                {
                    _NumChassi = value;
                }
            }}

        [Required(ErrorMessage="O modelo nao pode ser vazio.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "O modelo deve possuir no minimo 1 e no maximo 50 caracteres.")]
        public string? ModeloCarro {
            get{
                return _ModeloCarro;
            }set{
                if (value == null || value == "")
                {
                    throw new Exception("Erro ao tentar inserir um valor nulo ou vazio como ModeloCarro");
                } else
                {
                    _ModeloCarro = value;
                }
            }}

        [Required(ErrorMessage="A marca nao pode ser vazio.")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "A marca deve possuir no minimo 1 e no maximo 30 caracteres.")]
        public string? MarcaCarro {
            get{
                return _MarcaCarro;
            }set{
                if (value == null || value == "")
                {
                    throw new Exception("Erro ao tentar inserir um valor nulo ou vazio como MarcaCarro");
                } else
                {
                    _MarcaCarro = value;
                }
            }}

        [Required(ErrorMessage="O ano deve ter 4 numeros")]
        [Range(1, 9999, ErrorMessage="O ano deve ter 4 numeros de 1000 ate 9999.")]  
        public int AnoCarro {
            get{
                return _AnoCarro;
            }set{
                if (value < DateTime.Now.Year + 5)
                {
                    throw new Exception("Erro ao tentar inserir um numero muito alto como AnoCarro");
                } else
                {
                    _AnoCarro = value;
                }
            }}

        [Required(ErrorMessage="A cor do carro nao pode ser vazia.")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "A cor deve possuir no minimo 1 e no maximo 20 caracteres.")]
        public string? CorCarro {get{
                return _CorCarro;
            }set{
                if (value == null || value == "")
                {
                    throw new Exception("Erro ao tentar inserir um valor nulo ou vazio como CorCarro");
                } else
                {
                    _CorCarro = value;
                }
            }}

        [Required(ErrorMessage="O valor nao pode ser vazio")]
        [Range(0, 999999999.99, ErrorMessage="O valor deve ser entre 0 e 999999999,99.")]  
        public decimal ValorCarro {
            get{
                return _ValorCarro;
            }set{
                if (value < 0)
                {
                    throw new Exception("Erro ao tentar inserir um numero negativo como ValorCarro");
                } else
                {
                    _ValorCarro = value;
                }
            }}

        [Required(ErrorMessage="A quilometragem nao pode ser vazia")]
        [Range(0, 999999999.99, ErrorMessage="A quilometragem deve ser entre 0 e 999999999,99.")]  
        public float KmCarro {
            get{
                return _KmCarro;
            }set{
                if (value < 0)
                {
                    throw new Exception("Erro ao tentar inserir um numero negativo como KmCarro");
                } else
                {
                    _KmCarro = value;
                }
            }}

        [ForeignKey("Filial")]
        public int FkFilialCodFilial { get; set; }
    }
}