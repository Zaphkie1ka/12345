using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace CbIHNIIIA;

public partial class CommandWindow : Window
{
    public CommandWindow()
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

    private void Button_Add_Command(object? sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }
}