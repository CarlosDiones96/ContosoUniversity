using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models;
public class Student
{
    public int ID {get; set;}

    [Required]
    [StringLength(50)]
    [Display(Name = "Último nome")]
    public string LastName {get; set;}

    [Required]
    [StringLength(50, ErrorMessage = "Primeiro nome não pode exceder 50 caracteres.")]
    [Column("FirstName")]
    [Display(Name = "Primeiro nome")]
    public string FirstMidName {get; set;}

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "Data da matrícula")]
    public DateTime EnrollmentDate {get; set;}

    [Display(Name ="Nome completo")]
    public string FullName {
        get
        {
            return LastName + ", " + FirstMidName;
        }
    }
    public ICollection<Enrollment> Enrollments {get; set;}
}