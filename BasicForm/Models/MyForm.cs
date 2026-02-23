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
    
}