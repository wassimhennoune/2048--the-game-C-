using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using MahApps.Metro.Controls;

namespace _2048
{
    public partial class MainWindow : MetroWindow
    { 
        static public Dictionary<double, Color> map = new Dictionary<double, Color>();

        private Partie partie;
        private int best_score;
       
        public object Keys { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            ws_Copy.Visibility = Visibility.Hidden;
            backb.IsEnabled = false;
            partie = new Partie();
            nb.Content = partie._essai.ToString();        
            chargermap();
            ecrire();
            best_score = 0;
           
        }

        private void chargermap()
        {
           
            Color c = (Color)ColorConverter.ConvertFromString("#FFD8CCB9");
            map.Add(2, c);
            c = (Color)ColorConverter.ConvertFromString("#FFDEC398");
            map.Add(4, c);
            c = (Color)ColorConverter.ConvertFromString("#FFBD8B43");
            map.Add(8, c); 
             c = (Color)ColorConverter.ConvertFromString("#FFFF9700");
            map.Add(16, c);
            c = (Color)ColorConverter.ConvertFromString("#FFB2AA11");
            map.Add(32, c);
            c = (Color)ColorConverter.ConvertFromString("#FF615C0C");
            map.Add(64, c);
            c = (Color)ColorConverter.ConvertFromString("#FFD6591F");
            map.Add(128, c);
            c = (Color)ColorConverter.ConvertFromString("#FF932F00");
            map.Add(256, c);
            c = (Color)ColorConverter.ConvertFromString("#FFECE217");
            map.Add(512, c);
            c = (Color)ColorConverter.ConvertFromString("#FF1FA62C");
            map.Add(1024, c);
            c = (Color)ColorConverter.ConvertFromString("#FF4DD3CC");
             map.Add(2048, c);
            c = (Color)ColorConverter.ConvertFromString("#FFDFD991");
            map.Add(4096, c);
            c = (Color)ColorConverter.ConvertFromString("#FFDFD991");
            map.Add(8192, c);
            c = (Color)ColorConverter.ConvertFromString("#FFDFD991");
            map.Add(16384, c);

           

        }

        public void ecrire()
        {
          
            int i, j;
            ws.Children.Clear();
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    etiq e = new etiq(partie.t[i, j]);
                    ws.Children.Add(e);
                    Grid.SetRow(e, i);
                    Grid.SetColumn(e, j);

                }
            }
            if(partie._score<best_score)
            score_l .Content= partie._score.ToString();
            else
            {
                best_score = partie._score;
                b_score_l.Content = best_score.ToString();
                score_l.Content = partie._score.ToString();
                
            }
            
        }

       

        private void action(object sender, KeyEventArgs e)
        {

            if (!partie.go)
            {
                partie.empiler();
                switch (e.Key)
                {
                    case Key.Up: partie.up(); a(); break;
                    case Key.Down: partie.down(); a(); break;
                    case Key.Left: partie.left(); a(); break;
                    case Key.Right: partie.right(); a(); break;
                }
                ecrire();
            }
            
        }
        private void a()
        {
            if (partie._elem == 16)
            {
                if (partie.GameOver() == 1) { partie.kill(); ecrire(); ws_Copy.Visibility = Visibility.Visible; }
                else ws_Copy.Visibility = Visibility.Hidden;
            }
            else ws_Copy.Visibility = Visibility.Hidden;
            if (partie._essai > 0) { backb.IsEnabled = true; }
            else { backb.IsEnabled = false; }
          
        }

        private void back(object sender, RoutedEventArgs e)
        {
            
            if ((partie._essai > 0) && (partie.pile.Count>0))
            {

               partie.depiler(); ecrire(); partie._essai--;
                if (partie.go) { ws_Copy.Visibility = Visibility.Hidden; partie.go = false; }
                ecrire();

            }
            else { backb.IsEnabled = false; }
            nb.Content = partie._essai.ToString();
      

        }

        private void np(object sender, RoutedEventArgs e)
        {
            backb.IsEnabled = false;
            partie = new Partie();
            backb.Content = partie._essai.ToString();
            ecrire();
            ws_Copy.Visibility = Visibility.Hidden;
        }
    }
    } 
    

