namespace Build.Shared.Utils;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

/// <summary>
/// Entity helper class.
/// </summary>
public static class EntityHelper
{
  /// <summary>
  /// Provides ability to copy all properties of one entity. The method is suitable for usage when we are updating one entity.
  /// </summary>
  /// <typeparam name="T">Entity Type.</typeparam>
  /// <param name="destination">Destination object.</param>
  /// <param name="source">Source object.</param>
  /// <param name="propertiesToSkip">List of properties that has to be excluded from the copying.</param>
  /// <param name="useOnlySameType">Copy only properties are same type.</param>
  /// <exception cref="Exception">Throws exception if one or all of the object are null.</exception>
  public static void CopyEntityProperties<T1, T2>(this T1 destination,
                                                  T2 source,
                                                  IList<string> propertiesToSkip = null,
                                                  bool useOnlySameType = false)
  {

    ArgumentNullException.ThrowIfNull(source);
    ArgumentNullException.ThrowIfNull(destination);

    if (propertiesToSkip == null)
    {
      propertiesToSkip = new List<string>();
    }

    // Getting the Types of the objects
    Type destinationType = destination.GetType();
    Type sourceType = source.GetType();

    if (useOnlySameType && sourceType != destinationType)
    {
      throw new Exception("Source type and Destination type are different");
    }

    // Iterate the Properties of the source instance and
    // populate them to their desination counterparts.
    PropertyInfo[] sourceProperties = sourceType.GetProperties();
    foreach (PropertyInfo sourceProperty in sourceProperties)
    {
      if (propertiesToSkip.Contains(sourceProperty.Name))
      {
        continue;
      }

      if (!sourceProperty.CanRead)
      {
        continue;
      }

      PropertyInfo destinationProperty = destinationType.GetProperty(sourceProperty.Name);
      if (destinationProperty == null)
      {
        continue;
      }

      if (!destinationProperty.CanWrite)
      {
        continue;
      }

      if (destinationProperty.GetSetMethod(true) != null && destinationProperty.GetSetMethod(true).IsPrivate)
      {
        continue;
      }

      if ((destinationProperty.GetSetMethod().Attributes & MethodAttributes.Static) != 0)
      {
        continue;
      }

      if (!destinationProperty.PropertyType.IsAssignableFrom(sourceProperty.PropertyType))
      {
        continue;
      }



      var value = sourceProperty.GetValue(source, null);

      if (!sourceProperty.PropertyType.FullName.Contains("System") ||
          (sourceProperty.PropertyType.Name == typeof(List<>).Name))
      {
        var d = destinationProperty.GetValue(destination);

        if (value.GetType().Name == typeof(List<>).Name)
        {
          var counter = 0;
          foreach (var item in (IEnumerable)value)
          {
            var b = (IList)d;
            b[counter].CopyEntityProperties(item);
            counter++;
          }
          continue;
        }

        d.CopyEntityProperties(value);
        break;
      }

      // Finally Passed all tests, lets set the value
      destinationProperty.SetValue(destination, value, null);
    }
  }
}