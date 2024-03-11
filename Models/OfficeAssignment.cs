using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models;

public class OfficeAssignment
{
    [Key]
    public int InstructorID {get; set;}

    [StringLength(50)]
    [Display(Name = "Localização do escritório")]
    public string Location {get; set;}

    public Instructor Instructor {get; set;}
    
}