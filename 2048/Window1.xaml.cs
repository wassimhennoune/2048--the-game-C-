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
using System.Windows.Shapes;

namespace _2048
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1(int[,] t)
        {
            InitializeComponent();
       
            int i, j;
            ws.Children.Clear();
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    etiq e = new etiq(t[i, j]);
                    ws.Children.Add(e);
                    Grid.SetRow(e, i);
                    Grid.SetColumn(e, j);

                }
            }
          
    }
    }
}
