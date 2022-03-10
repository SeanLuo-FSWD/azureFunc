using System.ComponentModel.DataAnnotations;

namespace DataLayer.Models
{
public class Student {
  public string StudentId { get; set; }
  [Required]
  public string FirstName { get; set; }
  [Required]
  public string LastName { get; set; }
  [Required]
  public string School { get; set; }
}
}