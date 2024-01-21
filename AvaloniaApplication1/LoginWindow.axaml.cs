using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace AvaloniaApplication1;

public partial class LoginWindow : Window
{
    public LoginWindow()
    {
        InitializeComponent();
    }


    private void ConectButton(object? sender, RoutedEventArgs e)
    {
        if (string.IsNullOrEmpty(TextBox.Text))
        {
            TextBox.BorderBrush = Brushes.Orange;
        }
        else if (TextBox.Text == "0000")
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
        else
        {
            TextBox.BorderBrush = Brushes.Red;
        }
    }
}