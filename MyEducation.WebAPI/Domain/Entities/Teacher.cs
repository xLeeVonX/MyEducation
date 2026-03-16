namespace MyEducation.WebAPI.Domain.Entities;


[Table("Teachers")]
public class Teacher
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;
}
