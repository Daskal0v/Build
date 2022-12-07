namespace Build.Domain.ValueObjects;

public class Phone
{
    public string Number { get; private set; }
    public string Label { get; private set; }

    public Phone (string number, string label)
    {
        Number = number;
        Label = label;
    }
}
