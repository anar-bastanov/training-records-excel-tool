namespace ExcelTool.Models;

/// <summary>
/// Specifies the format of a file, usually distinguished by a file extension in its name.
/// </summary>
public enum FileFormat
{
    /// <summary>
    /// Represents an Excel (.xlsx) file.
    /// </summary>
    Excel = 1,
    /// <summary>
    /// Represents a JSON (.json) file.
    /// </summary>
    Json = 2,
    /// <summary>
    /// Represents an XML (.xml) file.
    /// </summary>
    XML = 3
}
