namespace Build.Domain.Entities;

using System;
using System.Globalization;
using Build.Domain.ValueObjects;

public class Contractor : BaseAggregateRoot<int>
{

    /// <summary>
    /// Gets or sets main user for this Contractor
    /// </summary>
    public int UserId { get; set; }

    /// <summary> 
    /// Gets or sets the Name of the Contractor
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the Phone of the Contractor
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// Gets or sets the Email of the Contractor
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Gets or sets the Address of the Contractor
    /// </summary>
    public Address Address { get; set; }


    /// <summary> 
    /// Gets or sets the Currency property 
    /// </summary>
    public string Currency { get; set; }

    /// <summary> Readonly property. Gets currency symbol based on the currency type </summary>
    public string CurrencySymbol
    {
        get
        {
            CultureInfo cultureInfoData = null; //GetContractorCultureFromCurrencyType(this.Currency);
            return cultureInfoData.NumberFormat.CurrencySymbol;
        }
    }

    /// <summary> 
    /// Gets or sets the IsActive property 
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// Gets or sets the first day of week for the contractor
    /// </summary>
    public DayOfWeek FirstDayOfWeek { get; set; }

    /// <summary> 
    /// Gets or sets the WeatherUnitType property 
    /// </summary>
    public string WeatherUnitType { get; set; }

    public int UTCOffset { get; set; }
}