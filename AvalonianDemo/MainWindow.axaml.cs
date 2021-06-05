using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AvalonianDemo
{
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
#if DEBUG
      this.AttachDevTools();
#endif
    }
    
    public void button_Click(object sender, RoutedEventArgs e)
    {
      // Change button text when button is clicked.
      var button = (Button)sender;
      button.Content = "Hello, Avalonia!";
      Console.WriteLine("Nice");
    }


    private void InitializeComponent()
    {
      AvaloniaXamlLoader.Load(this);
    }
  }
}
