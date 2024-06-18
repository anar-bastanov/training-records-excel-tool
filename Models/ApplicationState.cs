namespace ExcelTool.Models;

public enum ApplicationState
{
    Idle = 0b000,
    NewFile = 0b001,
    OpenFile = 0b101,
    NewFileUnsavedChanges = NewFile | UnsavedChanges,
    OpenFileUnsavedChanges = OpenFile | UnsavedChanges,

    UnsavedChanges = 0b010,
}
