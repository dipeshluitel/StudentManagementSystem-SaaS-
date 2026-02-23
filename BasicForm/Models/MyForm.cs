using System.ComponentModel.DataAnnotations;

namespace BasicForm.Models;

public class MyForm
{
    // [Required]
    public String Fname { get; set; }
    
    [Required]
    public String Lname { get; set; }
    
    [Required]
    [EmailAddress]
    public String Email { get; set; }
    
    [Required]
    [Range(0, 100)]
    public int Age { get; set; }
}