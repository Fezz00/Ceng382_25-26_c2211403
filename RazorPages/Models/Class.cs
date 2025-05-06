using System.ComponentModel.DataAnnotations;

namespace RazorPages.Models
{
public class Class {
    [Key]
    public int Id { get; set; }
    [Required]
    public string? ClassName { get; set; }
    [Required]
    public int? StudentCount { get; set; }
    public string? Description { get; set; }
    public bool isActive { get; set; } = true;
  }
}

//Feza