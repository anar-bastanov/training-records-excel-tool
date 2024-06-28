using System.ComponentModel;

namespace ExcelTool.Models;

/// <summary>
/// Represents a class model to store the necessary data for a trainee's profile information.
/// </summary>
public sealed class ProfileModel : INotifyPropertyChanged
{
    private string _trainee = "";

    private string _course = "";

    private string _position = "";

    private string _manager = "";

    /// <summary>
    /// Notifies all listeners about a change in value to implement two-way databinding with <see cref="INotifyPropertyChanged"/>.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// Gets or sets the name of the trainee.
    /// </summary>
    public string Trainee
    {
        get => _trainee;
        set => this.SetProperty(ref _trainee, value.ParseEntry(), PropertyChanged);
    }

    /// <summary>
    /// Gets or sets the name of the course that the trainee is enrolled in.
    /// </summary>
    public string Course
    {
        get => _course;
        set => this.SetProperty(ref _course, value.ParseEntry(), PropertyChanged);
    }

    /// <summary>
    /// Gets or sets the name of the trainee's position.
    /// </summary>
    public string Position
    {
        get => _position;
        set => this.SetProperty(ref _position, value.ParseEntry(), PropertyChanged);
    }

    /// <summary>
    /// Gets or sets the name of the trainee's manager.
    /// </summary>
    public string Manager
    {
        get => _manager;
        set => this.SetProperty(ref _manager, value.ParseEntry(), PropertyChanged);
    }
}
