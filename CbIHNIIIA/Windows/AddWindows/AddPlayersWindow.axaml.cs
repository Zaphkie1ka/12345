using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace CbIHNIIIA.Windows.AddWindows;

public partial class AddPlayersWindow : Window
{
    public AddPlayersWindow()
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

    private void Ext_Button(object? sender, RoutedEventArgs e)
    {
        Close();
    }

    private void Add_Button(object? sender, RoutedEventArgs e)
    {
        
    }
}