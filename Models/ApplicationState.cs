using System.Diagnostics;

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

public static class ApplicationStateExtensions
{
    public static ApplicationState MarkUnsavedChanges(this ApplicationState state)
    {
        Debug.Assert(state is not ApplicationState.Idle);
        return state | ApplicationState.UnsavedChanges;
    }

    public static ApplicationState UnmarkUnsavedChanges(this ApplicationState state)
    {
        Debug.Assert(state is not ApplicationState.Idle);
        return state & ~ApplicationState.UnsavedChanges;
    }

    public static bool HasUnsavedChanges(this ApplicationState state)
    {
        return (state & ApplicationState.UnsavedChanges) != 0;
    }
}
