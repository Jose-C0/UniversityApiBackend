using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels;

public class Course : BaseEntity
{
    [Required, StringLength(50)]
    public string Name { get; set; } = string.Empty;
    
    [Required, StringLength(280)]
    public string ShortDescription { get; set; } = string.Empty;
    
    [Required, StringLength(280)]
    public string Description { get; set; } = string.Empty;
	
	public Level Level { get; set; } = Level.Basico;
    
	// [Required]
	// public ICollection<Category> Categories { get; set; } = new List<Category>();
    public Category Categories { get; set; } = new Category();

	public Chapter Chapter { get; set; } = new Chapter();	
    
	[Required]
    public ICollection<Student> Students { get; set; } = new List<Student>();
}

public enum Level { Basico, Intermedio, Avanzado };


