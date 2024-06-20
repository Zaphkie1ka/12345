using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace CbIHNIIIA;

public partial class Menu : Window
{
    public Menu()
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

    private void Player_Button(object? sender, RoutedEventArgs e)
    {
        PlayersWindow windowHuman = new PlayersWindow();
        windowHuman.ShowDialog(this);
    }

    private void Events_Button(object? sender, RoutedEventArgs e)
    {
        EventsWindow windowEvents= new EventsWindow();
        windowEvents.ShowDialog(this);
    }

    private void Command_Button(object? sender, RoutedEventArgs e)
    {
        CommandWindow windowCommand = new CommandWindow();
        windowCommand.ShowDialog(this);
    }
}