namespace LibraryManagementSystem.Domain;

public class BaseModel
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}