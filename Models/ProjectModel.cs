using System.ComponentModel;

namespace ExcelTool.Models;

public sealed class ProjectModel : INotifyPropertyChanged
{
    public readonly ProfileModel ProfileInfo = new();

    public event PropertyChangedEventHandler? PropertyChanged
    {
        add => ProfileInfo.PropertyChanged += value;
        remove => ProfileInfo.PropertyChanged -= value;
    }
}
