using System;
using System.ComponentModel;

namespace ExcelTool.Models;

/// <summary>
/// Represents a class model to store the necessary data for a user project.
/// </summary>
public sealed class ProjectModel
{
    /// <summary>
    /// Gets the profile information of a trainee.
    /// </summary>
    public ProfileModel ProfileInfo { get; } = new();

    /// <summary>
    /// Gets the list of tasks assigned to a trainee.
    /// </summary>
    public BindingList<TaskModel> Tasks { get; } = new()
    {
        // This property must be set to true for databinding to work
        RaiseListChangedEvents = true
    };

    /// <summary>
    /// Initializes a new instance of the <see cref="ProjectModel"/> class with default values.
    /// </summary>
    public ProjectModel()
    {
        // Project changes if either profile information or assigned tasks change
        ProfileInfo.PropertyChanged += (_, _) => PropertyChanged?.Invoke();
        Tasks.ListChanged += (_, _) => PropertyChanged?.Invoke();
    }

    /// <summary>
    /// Notifies all listeners about a change in value.
    /// </summary>
    /// <remarks>
    /// This event is similar to <see cref="INotifyPropertyChanged.PropertyChanged"/>, which
    /// is used to implement two-way databinding. However, the purpose of the event for this
    /// class is to track unsaved changes.
    /// </remarks>
    public event Action? PropertyChanged;
}
