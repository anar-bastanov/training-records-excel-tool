using System.ComponentModel;

namespace ExcelTool.Models;

public sealed class ProjectModel : INotifyPropertyChanged
{
    public ProfileModel ProfileInfo { get; set; } = new();

    public event PropertyChangedEventHandler? PropertyChanged
    {
        add => ProfileInfo.PropertyChanged += value;
        remove => ProfileInfo.PropertyChanged -= value;
    }
}
