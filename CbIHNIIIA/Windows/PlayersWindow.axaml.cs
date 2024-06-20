using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace CbIHNIIIA;

public partial class PlayersWindow : Window
{
    public PlayersWindow()
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

    private void Button_Add_Players(object? sender, RoutedEventArgs e)
    {
        
    }
}