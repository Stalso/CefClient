using CefSharp;
using CefSharp.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace CefClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            Cef.Initialize(new CefSettings() {
                CachePath = "Mycache1",
                LogFile = "Mylog",
                
            },true,true);
            InitializeComponent();
           
            //var settings = new CefSettings();

            //settings.CachePath = "Mycache";
            //if (!Cef.Initialize(settings, shutdownOnProcessExit: true, performDependencyCheck: false))
            //{
            //    throw new Exception("Unable to Initialize Cef");
            //}
            //selfHostedBrowser.
            //ChromiumWebBrowser

            //selfHostedBrowser.BrowserSettings.
        }
    }
}
