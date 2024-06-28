using System.ComponentModel;

namespace ExcelTool.Models;

/// <summary>
/// Represents a class model to store the necessary data for a task that can be assigned to a trainee.
/// </summary>
public sealed class TaskModel : INotifyPropertyChanged
{
    private string _reference = "";

    private string _description = "";

    private string _trainingCategory = "";

    private string _type = "";

    private string _trainingStarted = "";

    private string _trainingCompleted = "";

    private string _trainerInitials = "";

    private string _certifierInitials = "";

    private string _certifyingScore = "";

    private string _requiredScore = "";

    /// <summary>
    /// Notifies all listeners about a change in value to implement two-way databinding with <see cref="INotifyPropertyChanged"/>.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// Initializes a new instance of the <see cref="TaskModel"/> class with default values.
    /// </summary>
    public TaskModel()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ProjectModel"/> class with values copied from another instance.
    /// </summary>
    /// <param name="taskModel">The instance to copy.</param>
    public TaskModel(TaskModel taskModel)
    {
        _reference = taskModel._reference;
        _description = taskModel._description;
        _trainingCategory = taskModel._trainingCategory;
        _type = taskModel._type;
        _trainingStarted = taskModel._trainingStarted;
        _trainingCompleted = taskModel._trainingCompleted;
        _trainerInitials = taskModel._trainerInitials;
        _certifierInitials = taskModel._certifierInitials;
        _certifyingScore = taskModel._certifyingScore;
        _requiredScore = taskModel._requiredScore;
    }

    // [DisplayNameAttribute(string)] is used to change the text inside the column headers in DataGridView

    /// <summary>
    /// Gets or sets the reference of the task.
    /// </summary>
    public string Reference
    {
        get => _reference;
        set => this.SetProperty(ref _reference, value, PropertyChanged);
    }

    /// <summary>
    /// Gets or sets the description of the task.
    /// </summary>
    public string Description
    {
        get => _description;
        set => this.SetProperty(ref _description, value, PropertyChanged);
    }

    /// <summary>
    /// Gets or sets the training category of the task.
    /// </summary>
    [DisplayName("Training Category")]
    public string TrainingCategory
    {
        get => _trainingCategory;
        set => this.SetProperty(ref _trainingCategory, value, PropertyChanged);
    }

    /// <summary>
    /// Gets or sets the type of the training.
    /// </summary>
    public string Type
    {
        get => _type;
        set => this.SetProperty(ref _type, value, PropertyChanged);
    }

    /// <summary>
    /// Gets or sets the date that the training started.
    /// </summary>
    [DisplayName("Training Started")]
    public string TrainingStarted
    {
        get => _trainingStarted;
        set => this.SetProperty(ref _trainingStarted, value, PropertyChanged);
    }

    /// <summary>
    /// Gets or sets the date that the training ended.
    /// </summary>
    [DisplayName("Training Completed")]
    public string TrainingCompleted
    {
        get => _trainingCompleted;
        set => this.SetProperty(ref _trainingCompleted, value, PropertyChanged);
    }

    /// <summary>
    /// Gets or sets the trainer's initials.
    /// </summary>
    [DisplayName("Trainer Initials")]
    public string TrainerInitials
    {
        get => _trainerInitials;
        set => this.SetProperty(ref _trainerInitials, value, PropertyChanged);
    }

    /// <summary>
    /// Gets or sets the certifier's initials.
    /// </summary>
    [DisplayName("Certifier Initials")]
    public string CertifierInitials
    {
        get => _certifierInitials;
        set => this.SetProperty(ref _certifierInitials, value, PropertyChanged);
    }

    /// <summary>
    /// Gets or sets the certifying score.
    /// </summary>
    [DisplayName("Certifying Score")]
    public string CertifyingScore
    {
        get => _certifyingScore;
        set => this.SetProperty(ref _certifyingScore, value, PropertyChanged);
    }

    /// <summary>
    /// Gets or sets the required amount of score.
    /// </summary>
    [DisplayName("Required Score")]
    public string RequiredScore
    {
        get => _requiredScore;
        set => this.SetProperty(ref _requiredScore, value, PropertyChanged);
    }
}
