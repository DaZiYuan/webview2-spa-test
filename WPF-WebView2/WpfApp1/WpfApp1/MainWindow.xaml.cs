using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            webview2.CoreWebView2InitializationCompleted += Webview2_CoreWebView2InitializationCompleted;
            webview2.Source = new Uri("https://appassets.example/index.html");
        }

        private void Webview2_CoreWebView2InitializationCompleted(object? sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            webview2.CoreWebView2.SetVirtualHostNameToFolderMapping(
  "appassets.example", "build", CoreWebView2HostResourceAccessKind.DenyCors);
        }
    }
}
