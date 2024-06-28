using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ExcelTool.Models;

/// <summary>
/// Defines extension methods for types that implement the <see cref="INotifyPropertyChanged"/>
/// interface to prevent declaring the same helper methods over and over again.
/// </summary>
public static class BindableBaseExtensions
{
    /// <summary>
    /// Sets the given property of an object and raises an event if the new value differs from 
    /// its old value.
    /// </summary>
    /// <remarks>
    /// This method should be called on the backing fields of properties from within their setters.
    /// </remarks>
    /// <typeparam name="TSelf">The type that this extension is defined for.</typeparam>
    /// <typeparam name="TProperty">The type of the property to be set.</typeparam>
    /// <param name="obj">The owner of <paramref name="property"/> which will be used as a sender when invoking <paramref name="event"/>.</param>
    /// <param name="property">The property to be set.</param>
    /// <param name="value">The value to set the property to.</param>
    /// <param name="event">The event to call when the property changes value.</param>
    /// <param name="propertyName">The name of the property as a string. This parameter is inferred by the compiler.</param>
    public static void SetProperty<TSelf, TProperty>(this TSelf obj, ref TProperty property, TProperty value,
        PropertyChangedEventHandler? @event, [CallerMemberName] string propertyName = "")
        where TSelf : INotifyPropertyChanged
    {
        if (EqualityComparer<TProperty>.Default.Equals(property, value))
            return;

        property = value;
        @event?.Invoke(obj, new PropertyChangedEventArgs(propertyName));
    }
}
