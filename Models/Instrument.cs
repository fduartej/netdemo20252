using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace netdemo20252.Models;

[Table("t_instrumento")]
public class Instrument
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string? Ticker { get; set; }
    public string? Nombre { get; set; }
    public string? Sector { get; set; }
    public string? Moneda { get; set; }
    public decimal PrecioActual { get; set; }
    public decimal CapitalizacionUSD { get; set; }
}