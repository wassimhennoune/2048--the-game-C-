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

namespace _2048
{
    /// <summary>
    /// Interaction logic for etiq.xaml
    /// </summary>
    public partial class etiq : UserControl
    {

        private double val;
        private Color color;

        public etiq(double val )
        {
            InitializeComponent();
            if (val == 0) wass.Content = "";
            else {
                wass.Content = val.ToString();
                this.val = val;
               Color c = MainWindow.map[val];
               col.Fill = new SolidColorBrush(c);
            }

                
        }
    }
}
