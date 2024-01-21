using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaApplication1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Edit(object? sender, RoutedEventArgs e)
    {
        AddWindow addWindow = new AddWindow();
        addWindow.Show();
        Close();
    }

    private void NewCreate(object? sender, RoutedEventArgs e)
    {
        AddWindow addWindow = new AddWindow();
        addWindow.Show();
        Close();
    }
}