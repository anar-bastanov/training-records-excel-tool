using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ExcelTool.Models;

public static class BindableBaseExtensions
{
    public static void SetProperty<T>(this object obj, ref T property, T value, PropertyChangedEventHandler? @event, [CallerMemberName] string propertyName = "")
    {
        if (EqualityComparer<T>.Default.Equals(property, value))
            return;

        property = value;
        @event?.Invoke(obj, new PropertyChangedEventArgs(propertyName));
    }
}
