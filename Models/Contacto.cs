using System.ComponentModel.DataAnnotations;
namespace netdemo.Models;

public class Contacto

{
    [Required(ErrorMessage = "El nombre es obligatorio.")   ]
    public string Nombre { get; set; }
    [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
    [EmailAddress(ErrorMessage = "El correo electrónico no es válido.")]
    public string Email { get; set; }
    [Required(ErrorMessage = "El mensaje es obligatorio.")]
    [StringLength(500, ErrorMessage = "El mensaje no puede exceder los 500 caracteres.")]
    public string Mensaje { get; set; }

    public Contacto()
    {
        Nombre = string.Empty;
        Email = string.Empty;
        Mensaje = string.Empty;
    }
}