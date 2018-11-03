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
    /// Logique d'interaction pour BoardWindow.xaml
    /// </summary>
    public partial class BoardWindow : Window
    {
        public BoardWindow()
        {
            InitializeComponent();
            FillCells();
        }


        private void FillCells()
        {
            int row = -1;


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

                            if (row == 0)
                            {
                                grid.Tag = tag + i;
                            }
                            else
                            {
                                tag = 9;
                                grid.Tag = tag - i;
                            }
                                
                            grid.Background = Brushes.Black;
                            grid.ColumnDefinitions.Add(gridColumn);

                            Grid gridInside = new Grid();
                            gridInside.Background = Brushes.LightGreen;
                            Grid.SetColumn(gridInside, i);
                            grid.Children.Add(gridInside);

                            for (int j = 0; j < 3; j++)
                            {
                                RowDefinition rowInside = new RowDefinition();

                                if (row == 0)
                                {
                                    if (j == 0)
                                        rowInside.Height = new GridLength(2, GridUnitType.Star);
                                    else
                                        rowInside.Height = new GridLength(1, GridUnitType.Star);
                                }
                                else
                                {
                                    if (j == 2)
                                        rowInside.Height = new GridLength(2, GridUnitType.Star);
                                    else
                                        rowInside.Height = new GridLength(1, GridUnitType.Star);
                                }


                                gridInside.RowDefinitions.Add(rowInside);

                                Label lbl = new Label();
                                lbl.Content = grid.Tag;
                                lbl.HorizontalAlignment = HorizontalAlignment.Center;
                                lbl.VerticalAlignment = VerticalAlignment.Center;
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
                        grid.Background = Brushes.Black;
                        Grid.SetColumn(grid, col);
                        Grid.SetRow(grid, 1);

                        int tag = 19;
                        for (int i = 0; i < 9; i++)
                        {
                            RowDefinition gridRow = new RowDefinition();
                            gridRow.Height = new GridLength(1, GridUnitType.Star);
                            
                            if (col == 0)
                            {
                                grid.Tag = tag - i;
                            }
                            else
                            {
                                tag = 31;
                                grid.Tag = tag + i;
                            }

                            grid.RowDefinitions.Add(gridRow);

                            Grid gridInside = new Grid();
                            gridInside.Background = Brushes.LightGreen;
                            Grid.SetRow(gridInside, i);
                            grid.Children.Add(gridInside);

                            for (int j = 0; j < 3; j++)
                            {
                                ColumnDefinition colInside = new ColumnDefinition();

                                if (col == 0)
                                {
                                    if (j == 0)
                                        colInside.Width = new GridLength(2, GridUnitType.Star);
                                    else
                                        colInside.Width = new GridLength(1, GridUnitType.Star);
                                }
                                else
                                {
                                    if (j == 2)
                                        colInside.Width = new GridLength(2, GridUnitType.Star);
                                    else
                                        colInside.Width = new GridLength(1, GridUnitType.Star);
                                }


                                gridInside.ColumnDefinitions.Add(colInside);

                                Label lbl = new Label();
                                lbl.Content = grid.Tag;
                                lbl.HorizontalAlignment = HorizontalAlignment.Center;
                                lbl.VerticalAlignment = VerticalAlignment.Center;
                                Grid.SetColumn(lbl, j);
                                gridInside.Children.Add(lbl);
                            }
                        }
                        Board.Children.Add(grid);
                    }
                }
            }
        }
    }
}
