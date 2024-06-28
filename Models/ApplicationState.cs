namespace ExcelTool.Models;

/// <summary>
/// Specifies the current state of the application as the user interacts with it.
/// </summary>
public enum ApplicationState
{
    /// <summary>
    /// The user is in the main menu.
    /// </summary>
    Idle = 0b000,
    /// <summary>
    /// The user is in the editor and a new project is created.
    /// </summary>
    NewFile = 0b001,
    /// <summary>
    /// The user is in the editor and an existing project is opened.
    /// </summary>
    OpenFile = 0b011,
    /// <summary>
    /// The user is in the editor and the new project is unsaved.
    /// </summary>
    NewFileUnsavedChanges = NewFile | UnsavedChanges, // 0b101
    /// <summary>
    /// The user is in the editor and the open project is unsaved.
    /// </summary>
    OpenFileUnsavedChanges = OpenFile | UnsavedChanges, // 0b111

    /// <summary>
    /// A bitflag corresponding to unsaved changes.
    /// </summary>
    /// <remarks>
    /// This bit is unused when the state is <see cref="Idle"/>.
    /// </remarks>
    UnsavedChanges = 0b100,
}
