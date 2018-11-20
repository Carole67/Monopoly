using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Monopoly.Handler;
using Monopoly.Model.Component.Cells;
using Monopoly.Model.Component;
using Monopoly.View.Component;
using Monopoly.View.Layout;

namespace Monopoly
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public GameManager GameManager { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            GameManager = GameManager.Instance;            
        }

        private void btnPlayAlone_Click(object sender, RoutedEventArgs e)
        {
            SimpleLayout SimpleLayout = new SimpleLayout();
            SimpleLayout.ChangeDataContext(new SinglePlayerControl());
            SimpleLayout.Show(); ;
        }

        private void btnCustomize_Click(object sender, RoutedEventArgs e)
        {
            CustomizeWindow custom = new CustomizeWindow();
            custom.Show();
        }

        private void btnNetworkPlay_Click(object sender, RoutedEventArgs e)
        {
            BoardWindow board = new BoardWindow();
            board.Show();
        }

        private void btnRules_Click(object sender, RoutedEventArgs e)
        {
            GameRules rules = new GameRules();
            rules.Show();
        }

    }
}
