using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace CbIHNIIIA;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void LogIn_Click(object? sender, RoutedEventArgs e)
    {
        if (loginbox.Text == "Admin" && passbox.Text == "123456")
        {
            Menu window2 = new Menu();
            window2.ShowDialog(this);
        }
    }

    private void Exit_Click(object? sender, RoutedEventArgs e)
    {
        Close();
    }
}