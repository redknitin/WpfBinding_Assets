using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WickedlyHigh
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            IAssetController assetCtl = new MockAssetController();
            MainWindow win = new MainWindow(assetCtl);
            win.Show();            
        }
    }
}
