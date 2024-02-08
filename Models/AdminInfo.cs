using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Models
{
    public class AdminInfo
    {
        [Key]
        [StringLength(30)]
        public string? LoginAdmin { get; set; }

        [StringLength(30)]
        public string? SenhaAdmin { get; set; }

        public bool RememberMe { get; set; }
    }
}