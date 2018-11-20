using Monopoly.Handler;
using Monopoly.Model.Component.Cells;
using Monopoly.Model.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Monopoly.View.Component
{
    /// <summary>
    /// Logique d'interaction pour BoardWindow.xaml
    /// </summary>
    public partial class BoardWindow : Window
    {
        public GameManager gameManager;
        public List<Player> players;
        public BoardWindow()
        {
            InitializeComponent();
            this.gameManager = GameManager.Instance;
            players = gameManager.playerHandler.ListOfPlayer;
            Console.WriteLine("Liste des utilisateurs présent dans la partie : ");

            foreach(Player p in players)
            {
                Console.WriteLine(p.Id + "-" + p.Name + '-' + p.Pawn.ColorValue);
            }
            FillCells();
        }


        #region Creation du Plateau
        private void FillCells()
        {
            int row = -1;
            BrushConverter bc = new BrushConverter();

            foreach (RowDefinition r in Board.RowDefinitions)
            {
                row++;
                int col = -1;

                foreach (ColumnDefinition c in Board.ColumnDefinitions)
                {
                    col++;

                    if ((row == 0 || row == 2) && col == 1)
                    {
                        Grid grid = new Grid();
                        Grid.SetColumn(grid, col);
                        Grid.SetRow(grid, row);

                        int tag = 21;

                        for (int i = 0; i < 9; i++)
                        {
                            ColumnDefinition gridColumn = new ColumnDefinition();
                            gridColumn.Width = new GridLength(1, GridUnitType.Star);
                            grid.ColumnDefinitions.Add(gridColumn);

                            Grid gridInside = new Grid();
                            Grid.SetColumn(gridInside, i);
                            grid.Children.Add(gridInside);




                            for (int j = 0; j < 2; j++)
                            {
                                RowDefinition rowInside = new RowDefinition();
                                TextBlock lbl = new TextBlock();
                                lbl.TextWrapping = TextWrapping.WrapWithOverflow;
                                ToolTip t = (ToolTip)Land.ToolTip;
                                lbl.ToolTip = t;

                                if (row == 0)
                                {
                                    lbl.Tag = tag + i;
                                }
                                else
                                {
                                    tag = 9;
                                    lbl.Tag = tag - i;
                                }

                                if (row == 0)
                                {
                                    if (j == 0)
                                    {
                                        rowInside.Height = new GridLength(3, GridUnitType.Star);
                                        lbl.Text = GameManager.Instance.boardHandler.Board.ListCell.ElementAt((int)lbl.Tag).Title.ToLower();
                                    }
                                    else
                                    {
                                        rowInside.Height = new GridLength(1, GridUnitType.Star);
                                        Cell mycell = GameManager.Instance.boardHandler.Board.GetCell((int)lbl.Tag);
                                        if (mycell.GetType() == typeof(Land))
                                        {
                                            lbl.Background = (Brush)bc.ConvertFrom(GameManager.Instance.boardHandler.getColor(mycell));
                                        }
                                        else
                                        {
                                            lbl.Background = Brushes.Transparent;
                                        }

                                    }
                                }
                                else
                                {
                                    if (j == 1)
                                    {
                                        rowInside.Height = new GridLength(3, GridUnitType.Star);
                                        lbl.Text = GameManager.Instance.boardHandler.Board.ListCell.ElementAt((int)lbl.Tag).Title.ToLower();

                                    }
                                    else
                                    {
                                        rowInside.Height = new GridLength(1, GridUnitType.Star);
                                        lbl.Background = (Brush)bc.ConvertFrom(GameManager.Instance.boardHandler.getColor(GameManager.Instance.boardHandler.Board.GetCell((int)lbl.Tag)));
                                    }

                                }

                                gridInside.RowDefinitions.Add(rowInside);

                                Grid.SetRow(lbl, j);
                                gridInside.Children.Add(lbl);
                            }

                            /*Border border = new Border();
                            Grid.SetColumn(border, i);                                    
                            border.Child = lbl;
                            border.Margin = new Thickness(1);
                            border.BorderBrush = Brushes.Black;*/

                        }
                        Board.Children.Add(grid);
                    }
                    else if (col == 0 || col == 2)
                    {
                        Grid grid = new Grid();
                        Grid.SetColumn(grid, col);
                        Grid.SetRow(grid, 1);

                        int tag = 19;
                        for (int i = 0; i < 9; i++)
                        {
                            RowDefinition gridRow = new RowDefinition();
                            gridRow.Height = new GridLength(1, GridUnitType.Star);
                            grid.RowDefinitions.Add(gridRow);

                            Grid gridInside = new Grid();
                            Grid.SetRow(gridInside, i);
                            grid.Children.Add(gridInside);

                            for (int j = 0; j < 2; j++)
                            {
                                ColumnDefinition colInside = new ColumnDefinition();
                                TextBlock lbl = new TextBlock();
                                lbl.TextWrapping = TextWrapping.WrapWithOverflow;
                                lbl.TextAlignment = TextAlignment.Center;

                                if (col == 0)
                                {
                                    lbl.Tag = tag - i;
                                }
                                else
                                {
                                    tag = 31;
                                    lbl.Tag = tag + i;
                                }

                                //ToolTip t = (ToolTip)Land.ToolTip;
                                ToolTip t = new ToolTip();
                                lbl.ToolTip = t;
                                t.Opened +=  new RoutedEventHandler(whenToolTipOpens);
                                //t.Closed +=  new RoutedEventHandler(whenToolTipCloses);
                                

                               FillCardLand((int)lbl.Tag);

                                if (col == 0)
                                {
                                    if (j == 0)
                                    {
                                        colInside.Width = new GridLength(4, GridUnitType.Star);
                                        lbl.Text = GameManager.Instance.boardHandler.Board.ListCell.ElementAt((int)lbl.Tag).Title;
                                        lbl.Background = Brushes.White;
                                    }
                                    else
                                    {
                                        colInside.Width = new GridLength(1, GridUnitType.Star);
                                        //lbl.Background = (Brush)bc.ConvertFrom(GameManager.Instance.boardHandler.getColor(GameManager.Instance.boardHandler.Board.GetCell((int)lbl.Tag)));
                                        Cell mycell = GameManager.Instance.boardHandler.Board.GetCell((int)lbl.Tag);
                                        if (mycell.GetType() == typeof(Land))
                                        {
                                            lbl.Background = (Brush)bc.ConvertFrom(GameManager.Instance.boardHandler.getColor(mycell));
                                        }
                                        else
                                        {
                                            lbl.Background = Brushes.Transparent;
                                        }
                                    }

                                }
                                else
                                {
                                    if (j == 1)
                                    {
                                        colInside.Width = new GridLength(3, GridUnitType.Star);
                                        lbl.Text = GameManager.Instance.boardHandler.Board.ListCell.ElementAt((int)lbl.Tag).Title;
                                        lbl.Background = Brushes.White;
                                    }
                                    else
                                    {
                                        colInside.Width = new GridLength(1, GridUnitType.Star);
                                        lbl.Background = (Brush)bc.ConvertFrom(GameManager.Instance.boardHandler.getColor(GameManager.Instance.boardHandler.Board.GetCell((int)lbl.Tag)));
                                    }
                                }


                                gridInside.ColumnDefinitions.Add(colInside);



                                //lbl.HorizontalAlignment = HorizontalAlignment.Center;
                                //lbl.VerticalAlignment = VerticalAlignment.Center;
                                Grid.SetColumn(lbl, j);
                                gridInside.Children.Add(lbl);
                            }
                        }
                        Board.Children.Add(grid);
                    }
                }
            }
        }


        private void FillCardLand(int tag)
        {
            var cell = GameManager.Instance.boardHandler.Board.ListCell.ElementAt(tag);
            string type = cell.GetType().Name;
            
            switch(type)
            {
                case "DrawCard":
                    break;
                case "GoToJail":
                    break;
                case "Jail":                 
                    break;
                case "Land":
                    Land l = (Land)GameManager.Instance.boardHandler.Board.ListCell.ElementAt(tag);               
                    lblBuyingPriceValue2.Content = l.PurchasePrice;
                    lblLandValue2.Content = l.RantalList[0];
                    lblHouse1Value2.Content = l.RantalList[1];
                    lblHouse2Value2.Content = l.RantalList[2];
                    lblHouse3Value2.Content = l.RantalList[3];
                    lblHouse4Value2.Content = l.RantalList[4];
                    lblMotelValue2.Content = l.RantalList[5];
                    lblMortgage2.Content = l.MortgagePrice;                   
                    break;               
                case "Parking":
                    break;
                case "Property":
                    break;
                case "TrainStation":
                    break;
                case "PublicService":
                    break;
                case "Tax":
                    break;
                
                default:
                    LandTitle.Content = cell.Title;
                    break;
            }
            

        }

        /*private void TextBlock_MouseHover(object sender, EventArgs e)
        { 
            ToolTip t = new ToolTip();
            t.Content = (ToolTip)Land.ToolTip;
            
            //LandTitle.Background = (Brush)bc.ConvertFrom(GameManager.Instance.boardHandler.getColor(GameManager.Instance.boardHandler.Board.GetCell((int)grid.Tag)));

            //lblBuyingPrice. 

            //System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            //ToolTip1.SetToolTip(this.button1, this.button1.Text);
        }*/


        void whenToolTipOpens(object sender, RoutedEventArgs e)
        {
            if (sender.GetType().FullName.Equals("System.Windows.Controls.ToolTip"))
            {
                string s = sender.GetType().FullName;
                ToolTip t = (ToolTip)sender;
                Popup p = (Popup)t.Parent;
                t = (ToolTip)Land.ToolTip;
                //int val = (int) (sender as TextBlock).Tag; 
                //ell = (Ellipse)p.PlacementTarget;
                //ell.Fill = Brushes.Blue;
            }
        }
        
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult dialog = MessageBox.Show("Voulez-vous vraiment quitter la partie ?", "Quitter la partie", MessageBoxButton.YesNo);
   
            if (dialog == MessageBoxResult.No)
                e.Cancel = true;           
        }

        /*void whenToolTipCloses(object sender, RoutedEventArgs e)
        {
            Ellipse ell = new Ellipse();
            if (sender.GetType().FullName.Equals(
                              "System.Windows.Shapes.Ellipse"))
            {
                ell = (Ellipse)sender;
                ell.Fill = Brushes.Gray;
            }
            else if (sender.GetType().FullName.Equals(
                                   "System.Windows.Controls.ToolTip"))
            {
                ToolTip t = (ToolTip)sender;
                Popup p = (Popup)t.Parent;
                ell = (Ellipse)p.PlacementTarget;
                ell.Fill = Brushes.Gray;
            }
        }*/

        #endregion
       

    }
}
