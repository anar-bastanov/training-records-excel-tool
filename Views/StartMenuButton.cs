using System;
using System.ComponentModel;

namespace ExcelTool.Views;

[DefaultEvent(nameof(Click))]
public partial class StartMenuButton : UserControl
{
    public StartMenuButton()
    {
        InitializeComponent();

    }

    [Browsable(true)]
    public string ButtonText
    {
        get => _buttonText.Text;
        set => _buttonText.Text = value;
    }

    [Browsable(true)]
    public Image? ButtonIcon
    {
        get => _buttonIcon.BackgroundImage;
        set => _buttonIcon.BackgroundImage = value;
    }

    [Browsable(true)]
    public new event EventHandler Click
    {
        add
        {
            base.Click += value;
            foreach (Control control in Controls)
            {
                control.Click += value;
            }
        }
        remove
        {
            base.Click -= value;
            foreach (Control control in Controls)
            {
                control.Click -= value;
            }
        }
    }
}
