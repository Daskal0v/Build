namespace Build.Shared.Utils;

using System;
using Google.Protobuf.WellKnownTypes;

/// <summary>
/// Date time offset Helper.
/// </summary>
public static class DateTimeOffsetHelper
{
    /// <summary>
    /// Extension method to help resolving the DateTimeOffset with a proper offset.
    /// </summary>
    /// <param name="timestamp">Timestamp.</param>
    /// <returns>DateTimeOffset.</returns>
    public static DateTimeOffset ConvertTimeStampToDateTimeWithOffset(this Timestamp timestamp)
    {
        var stringRepresentation = timestamp.ToString().Trim(new char [] { '\"' });

        if (DateTime.TryParse(stringRepresentation, out var dateTime))
        {
            return new DateTimeOffset(dateTime);
        }

        return default(DateTimeOffset);
    }
}