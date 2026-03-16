namespace MyEducation.WebAPI.Domain.Entities;


[Table("Subjects")]
public class Subject
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;
}
