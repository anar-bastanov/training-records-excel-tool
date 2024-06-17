using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ExcelTool.Models;

public sealed class ProfileModel : INotifyPropertyChanged
{
    private string _trainee = "";

    private string _course = "";

    private string _position = "";
    
    private string _manager = "";

    public event PropertyChangedEventHandler? PropertyChanged;

    public string Trainee
    {
        get => _trainee;
        set => SetProperty(ref _trainee, value);
    }

    public string Course
    { 
        get => _course;
        set => SetProperty(ref _course, value);
    }

    public string Position
    {
        get => _position;
        set => SetProperty(ref _position, value);
    }

    public string Manager
    {
        get => _manager;
        set => SetProperty(ref _manager, value);
    }

    private void SetProperty(ref string property, string value, [CallerMemberName] string propertyName = "")
    {
        if (property == value)
            return;

        property = value;
        OnPropertyChanged(propertyName);
    }

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
