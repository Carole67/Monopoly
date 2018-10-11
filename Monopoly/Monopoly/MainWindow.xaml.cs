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
using Monopoly.Model.Component.Board;

namespace Monopoly
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Board Board;
        Label monLabel;
        public MainWindow()
        {
            InitializeComponent();
            this.Board = new Board("Monopoly Board", new ObservableCollection<Square> { new Square("AVENU DE BRETEUIL"), new Square("A VENUE FOCH") });
            this.AddChild(Board);
            
        }
        
        /// <summary>
        ///  Génération du plateau de jeux
        /// </summary>
        public void generation(string path)
        {
            this.Title = "Monopoly Game";
            //DockPanel MainDockPanelLayout = new DockPanel();
            //DockPanel.SetDock(new Plateau("", null), Dock.Right);

            //this.Content = MainDockPanelLayout;

            //XmlSerializer xs = new XmlSerializer(typeof(Plateau));
            //using (StreamReader sr = new StreamReader(path))
            //{
            //    xs.Serialize(sr, Plateau);
            //}
            
        }
    }
}
