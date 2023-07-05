using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels;


public class Curso : BaseEntity
{
    [Required, StringLength(280)]
    public string Nombre { get; set; } = string.Empty;
    
    [Required, StringLength(280)]
    public string DescripcionCorta { get; set; } = string.Empty;
    
    [Required, StringLength(280)]
    public string DescripcionLarga { get; set; } = string.Empty;
    
    public string PublicoObjetivo { get; set; } = string.Empty;
    
    [Required]
    public string Objetivos { get; set; } = string.Empty;
    
    [Required]
    public string Requisitos { get; set; } = string.Empty;

    public Level? Nivel { get; set; }
    

}

public enum Level { Básico, Intermedio, Avanzado };

