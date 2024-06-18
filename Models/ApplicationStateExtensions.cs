using System.Diagnostics;

namespace ExcelTool.Models;

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
