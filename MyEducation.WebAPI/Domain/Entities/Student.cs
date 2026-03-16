namespace MyEducation.WebAPI.Domain.Entities;


[Table("Students")]
public class Student
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;
}
