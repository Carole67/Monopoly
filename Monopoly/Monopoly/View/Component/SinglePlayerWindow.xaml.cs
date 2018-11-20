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
using Monopoly.Handler;
using Monopoly.Handler.Entity;
using Monopoly.Model.Component;

namespace Monopoly.View.Component
{
    /// <summary>
    /// Logique d'interaction pour SinglePlayerPageView.xaml
    /// </summary>
    public partial class SinglePlayerWindow : Window
    {
        private static ColorHandler colorHandler;
        private static GameManager gameManager;
        public Player player;
        public string ColorValue;

        public SinglePlayerWindow()
        {
            InitializeComponent();
            colorHandler = ColorHandler.Instance;
            gameManager = GameManager.Instance;
        }

        private void onGotFocus_Pseudo(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Get Focus");
            TextBox_Pseudo.Text = "";
        }

        private void onLostFocus_Pseudo(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TextBox_Pseudo.Text))
            {
                TextBox_Pseudo.Text = "Your Pseudo";
            }
        }


        private void onClickPreviousColor(object sender, RoutedEventArgs e)
        {
            BrushConverter bc = new BrushConverter();
            ColorValue = colorHandler.GetNextPawnColor();
            PawnIcon.Fill = (Brush)bc.ConvertFrom(ColorValue);
        }

        private void onClickNextColor(object sender, RoutedEventArgs e)
        {
            BrushConverter bc = new BrushConverter();
            ColorValue = colorHandler.GetPreviousPawnColor();
            PawnIcon.Fill = (Brush)bc.ConvertFrom(ColorValue);
        }

        private void onClickValidate(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Creation du joueur");
            gameManager.CreateSinglePlayer(this.TextBox_Pseudo.Text, ColorValue);
            Console.WriteLine("Fin de la creation");
            Window.GetWindow(this).Close();

            BoardWindow custom = new BoardWindow();
            custom.Show();
        }
    }
}
