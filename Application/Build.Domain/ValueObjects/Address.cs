namespace Build.Domain.ValueObjects;

public class Address
{
    public string Country { get; private set; }
    public string State { get; private set; }
    public string City { get; private set; }
    public string Region { get; private set; }
    public string AddressLine1 { get; private set; }
    public string AddressLine2 { get; private set; }
    public string PostalCode { get; private set; }

    public Address (string country, string state, string city, string region, string addressLine1, string addressLine2, string postalCode)
    {
        Country = country;
        State = state;
        City = city;
        Region = region;
        PostalCode = postalCode;
        AddressLine1 = addressLine1;
        AddressLine2 = addressLine2;
    }
}
