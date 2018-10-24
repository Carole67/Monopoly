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

namespace Monopoly.View.Component
{
    /// <summary>
    /// Logique d'interaction pour CustomizeWindow.xaml
    /// </summary>
    public partial class CustomizeWindow : Window
    {
        public List<Brush> ColorsList { get; set; }

        public Brush SelectedColor { get; set; }

        public CustomizeWindow()
        {
            InitializeComponent();

            ColorsList = new List<Brush>()
            {
                Brushes.Red,
                Brushes.GreenYellow,
                Brushes.Orange,
                Brushes.Yellow,
                Brushes.Green,
                Brushes.Blue,
                Brushes.Pink,
                Brushes.Purple               
            };

            DataContext = this;
        }
    }


}
