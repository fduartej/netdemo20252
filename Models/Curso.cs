using System.ComponentModel.DataAnnotations;

namespace netdemo.Models;
public class Curso
{
    public int Id { get; set; }
    [Required(ErrorMessage = "El nombre del curso es obligatorio.")]
    public string? Nombre { get; set; }
    [Required(ErrorMessage = "La descripción del curso es obligatoria.")]
    public string? Descripcion { get; set; }
    [Range(1, 10, ErrorMessage = "La duración del curso debe estar entre 1 y 10 semanas.")]
    public int Duracion { get; set; }
}
