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

namespace Monopoly.View.Component
{
    /// <summary>
    /// Logique d'interaction pour SinglePlayerControl.xaml
    /// </summary>
    public partial class SinglePlayerControl : UserControl
    {
        public SinglePlayerControl()
        {
            InitializeComponent();
        }

        private void onGotFocus_Pseudo(object sender, RoutedEventArgs e)
        {
            TextBox_Pseudo.Text = "";
        }

        private void onLostFocus_Pseudo(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox_Pseudo.Text))
            {
                TextBox_Pseudo.Text = "Your Pseudo";
            }
        }
    }
}
