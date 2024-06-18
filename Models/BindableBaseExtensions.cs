using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ExcelTool.Models;

public static class BindableBaseExtensions
{
    public static void SetProperty(this object obj, ref string property, string value, PropertyChangedEventHandler? @event, [CallerMemberName] string propertyName = "")
    {
        if (property == value)
            return;

        property = value;
        @event?.Invoke(obj, new PropertyChangedEventArgs(propertyName));
    }
}
