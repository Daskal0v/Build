namespace Build.Domain.Entities;

using Build.Domain.ValueObjects;

public class User : BaseAggregateRoot<int>
{
    public FileInfo Photo { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Phone Phone { get; set; }
    public string Email { get; set; }
    public int UTCOffset { get; set; }

    public bool IsActive { get; set; }

    public IList<Project> Projects { get; set; }
}
