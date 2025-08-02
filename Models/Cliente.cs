using System.ComponentModel.DataAnnotations;


namespace netdemo.Models;

public class Cliente
{
    public int Id { get; set; }
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string? Nombre { get; set; }
    [Required(ErrorMessage = "El apellido es obligatorio.")]
    public string? Apellido { get; set; }
    [EmailAddress(ErrorMessage = "El correo electrónico no es válido.")]
    public string? Email { get; set; }
}
