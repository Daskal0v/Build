namespace Build.Domain.ValueObjects;

public class Budget
{
    public string Currency { get; private set; }
    /// <summary>
    /// Project budget including Materials and Labor.
    /// </summary>
    public double Amount { get; private set; }
}
