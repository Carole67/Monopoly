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

namespace Monopoly.View.Layout
{
    /// <summary>
    /// Logique d'interaction pour SimpleLayout.xaml
    /// </summary>
    public partial class SimpleLayout : Window
    {
        public SimpleLayout()
        {
            InitializeComponent();
        }

        public void ChangeDataContext(UserControl content)
        {
            this.DataContext = content;
        }
    }
}
