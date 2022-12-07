namespace Build.Domain.Entities;

using Build.Domain.Enums;
using Build.Domain.ValueObjects;

public class Project : BaseAggregateRoot<Guid>
{
    public int UserId { get; set; }

    /// <summary>
    /// Gets or sets the Name of the project.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the description of the project.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets description of the scope of the project.
    /// </summary>
    public string Scope { get; set; }

    /// <summary>
    /// Gets or sets short description of goals of the project.
    /// </summary>
    public string Objectives { get; set; }

    /// <summary>
    /// Gets or sets project Address.
    /// </summary>
    public Address Address { get; set; }

    /// <summary>
    /// Gets or sets GPS Coordinates of the project/Location.
    /// </summary>
    public GeoLocation GeoLocation { get; set; }

    /// <summary>
    /// Gets or sets project type
    /// </summary>
    public ProjectType Type { get; set; }

    /// <summary>
    /// Gets or sets property type which is object to the project.
    /// </summary>
    public PropertyType PropertyType { get; set; }

    /// <summary>
    /// Gets or sets the project phase.
    /// </summary>
    public ProjectPhase Phase { get; set; }

    /// <summary>
    /// Gets or sets the source of the project.
    /// </summary>
    public ProjectSource Source { get; set; }
    public bool IsGeneralContractorNeeded { get; set; }
    public bool IsArchitectNeeded { get; set; }
    public bool IsInteriorDesignerNeeded { get; set; }

    /// <summary>
    /// Gets or sets the project budget
    /// </summary>
    public Budget Budget { get; set; }

    /// <summary>
    /// Gets or sets Financial type of the project.
    /// </summary>
    public FinancialType FinancialType { get; set; }

    public DateTimeOffset EndDate { get; set; }
    //public DateTimeOffset Finished { get; set; }
    //public DateTimeOffset WarrantyExpirationDate { get; set; }

    public List<FileInfo> Files { get; set; }
}
