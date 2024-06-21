using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ExcelTool.Models;

public static class BindableBaseExtensions
{
    public static void SetProperty<T>(this object obj, ref T property, T value, PropertyChangedEventHandler? @event, [CallerMemberName] string propertyName = "")
        where T : IEquatable<T>
    {
        if (property.Equals(value))
            return;

        property = value;
        @event?.Invoke(obj, new PropertyChangedEventArgs(propertyName));
    }
}
