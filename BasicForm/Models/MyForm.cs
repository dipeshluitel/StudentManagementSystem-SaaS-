using System.ComponentModel.DataAnnotations;

namespace BasicForm.Models;

public class MyForm
{
    // [Required]
    public String Username { get; set; }
    
    [Required]
    public String Password { get; set; }
    
    [Required]
    [EmailAddress]
    public String Email { get; set; }
    
    public Int32 TotalStudent {get; set;}
    public Int32 TotalTeacher {get; set;}
    public Int32 TotalSubject {get; set;}
    public Int32 TotalExam {get; set;}
}