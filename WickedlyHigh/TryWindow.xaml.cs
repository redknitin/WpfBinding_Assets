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

namespace WickedlyHigh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class TryWindow : Window
    {
        public IAssetController MyAssetController { get; set; }
        public List<AssetEntity> Assets { 
            get { return MyAssetController.GetAssets(); }            
        }

        public TryWindow(IAssetController aAssetController)
        {
            MyAssetController = aAssetController;
            InitializeComponent();
        }
    }
}
