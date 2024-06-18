using System.ComponentModel;

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
        set => this.SetProperty(ref _trainee, value, PropertyChanged);
    }

    public string Course
    { 
        get => _course;
        set => this.SetProperty(ref _course, value, PropertyChanged);
    }

    public string Position
    {
        get => _position;
        set => this.SetProperty(ref _position, value, PropertyChanged);
    }

    public string Manager
    {
        get => _manager;
        set => this.SetProperty(ref _manager, value, PropertyChanged);
    }
}
