using System;
using System.ComponentModel;

namespace ExcelTool.Views;

/// <summary>
/// Represents a Windows button control with an image and a text.
/// </summary>
[DefaultEvent(nameof(Click))]
public partial class StartMenuButtonUserControl : UserControl
{
    /// <summary>
    /// Initializes a new instance of the <see cref="StartMenuButtonUserControl"/> class.
    /// </summary>
    public StartMenuButtonUserControl()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Gets or sets the text on the <see cref="StartMenuButtonUserControl"/>.
    /// </summary>
    [Browsable(true)]
    public string ButtonText
    {
        get => _buttonText.Text;
        set => _buttonText.Text = value;
    }

    /// <summary>
    /// Gets or sets the image on the <see cref="StartMenuButtonUserControl"/>.
    /// </summary>
    [Browsable(true)]
    public Image? ButtonIcon
    {
        get => _buttonIcon.BackgroundImage;
        set => _buttonIcon.BackgroundImage = value;
    }

    /// <inheritdoc cref="Control.Click"/>
    [Browsable(true)]
    public new event EventHandler Click
    {
        add
        {
            base.Click += value;

            // Makes sure that no matter where you click on the control, whether
            // it is the panel, the text, or the image, the click event is fired
            foreach (Control control in Controls)
            {
                control.Click += value;
            }
        }
        remove
        {
            base.Click -= value;

            // The same reason as in the add accessor
            foreach (Control control in Controls)
            {
                control.Click -= value;
            }
        }
    }
}
