using System.ComponentModel;

namespace ExcelTool.Models;

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

    public event PropertyChangedEventHandler? PropertyChanged;

    public string Reference
    {
        get => _reference;
        set => this.SetProperty(ref _reference, value, PropertyChanged);
    }

    public string Description
    {
        get => _description;
        set => this.SetProperty(ref _description, value, PropertyChanged);
    }

    [DisplayName("Training Category")]
    public string TrainingCategory
    {
        get => _trainingCategory;
        set => this.SetProperty(ref _trainingCategory, value, PropertyChanged);
    }

    public string Type
    {
        get => _type;
        set => this.SetProperty(ref _type, value, PropertyChanged);
    }

    [DisplayName("Training Started")]
    public string TrainingStarted
    {
        get => _trainingStarted;
        set => this.SetProperty(ref _trainingStarted, value, PropertyChanged);
    }

    [DisplayName("Training Completed")]
    public string TrainingCompleted
    {
        get => _trainingCompleted;
        set => this.SetProperty(ref _trainingCompleted, value, PropertyChanged);
    }

    [DisplayName("Trainer Initials")]
    public string TrainerInitials
    {
        get => _trainerInitials;
        set => this.SetProperty(ref _trainerInitials, value, PropertyChanged);
    }

    [DisplayName("Certifier Initials")]
    public string CertifierInitials
    {
        get => _certifierInitials;
        set => this.SetProperty(ref _certifierInitials, value, PropertyChanged);
    }

    [DisplayName("Certifying Score")]
    public string CertifyingScore
    {
        get => _certifyingScore;
        set => this.SetProperty(ref _certifyingScore, value, PropertyChanged);
    }

    [DisplayName("Required Score")]
    public string RequiredScore
    {
        get => _requiredScore;
        set => this.SetProperty(ref _requiredScore, value, PropertyChanged);
    }

    public TaskModel Copy()
    {
        return new()
        {
            Reference = Reference,
            Description = Description,
            TrainingCategory = TrainingCategory,
            Type = Type,
            TrainingStarted = TrainingStarted,
            TrainingCompleted = TrainingCompleted,
            TrainerInitials = TrainerInitials,
            CertifierInitials = CertifierInitials,
            CertifyingScore = CertifyingScore,
            RequiredScore = RequiredScore
        };
    }
}
