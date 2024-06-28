using System.Diagnostics;

namespace ExcelTool.Models;

/// <summary>
/// Defines extension methods for the enum <see cref="ApplicationState"/> to encapsulate common
/// operations that involve bit manipulations.
/// </summary>
public static class ApplicationStateExtensions
{
    /// <summary>
    /// Converts <paramref name="state"/> to indicate that the project has unsaved changes.
    /// </summary>
    /// <remarks>
    /// <paramref name="state"/> is assumed not to be <see cref="ApplicationState.Idle"/>.
    /// </remarks>
    /// <param name="state">The state to convert.</param>
    /// <returns>A state with the <see cref="ApplicationState.UnsavedChanges"/> flag set.</returns>
    public static ApplicationState MarkUnsavedChanges(this ApplicationState state)
    {
        Debug.Assert(state is not ApplicationState.Idle);
        return state | ApplicationState.UnsavedChanges;
    }

    /// <summary>
    /// Converts <paramref name="state"/> to indicate that the project is saved.
    /// </summary>
    /// <remarks>
    /// <paramref name="state"/> is assumed not to be <see cref="ApplicationState.Idle"/>.
    /// </remarks>
    /// <param name="state">The state to convert.</param>
    /// <returns>A state with the <see cref="ApplicationState.UnsavedChanges"/> flag unset.</returns>
    public static ApplicationState UnmarkUnsavedChanges(this ApplicationState state)
    {
        Debug.Assert(state is not ApplicationState.Idle);
        return state & ~ApplicationState.UnsavedChanges;
    }

    /// <summary>
    /// Checks whether the current project has unsaved changes.
    /// </summary>
    /// <param name="state">The state to examine.</param>
    /// <returns><see langword="true"/> if there are some unsaved changes left; otherwise, <see langword="false"/>.</returns>
    public static bool HasUnsavedChanges(this ApplicationState state)
    {
        return (state & ApplicationState.UnsavedChanges) != 0;
    }
}
