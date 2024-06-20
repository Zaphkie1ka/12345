using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace CbIHNIIIA.Windows.AddWindows;

public partial class AddEventsWindow : Window
{
    public AddEventsWindow()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}