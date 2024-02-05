using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
    public class DateFilter
    {
    public DateOnly DataIni { set; get; }
    public DateOnly DataFin { set; get; }
    }
}