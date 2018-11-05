using Monopoly.Model.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Monopoly.Settings;

namespace Monopoly.ViewModels
{
    public class SinglePlayerViewModel
    {
        public Player CurrentPlayer { get; set; }
        public string Pseudo { get; set; }
        public string ColorValue { get; set; }
        private int _indexColor;

        /// <summary>
        /// Création d'une instance de la classe
        /// </summary>
        public SinglePlayerViewModel()
        {
            this.CurrentPlayer = new Player();
            this.Pseudo = this.CurrentPlayer.Name;
            this._indexColor = SettingColor.RED;
            this.ColorValue = SettingColor.PawnColors[this._indexColor];
        }

        /// <summary>
        /// Cherche la couleur précédante
        /// </summary>
        public void NextColorLeft()
        {
            this._indexColor = (this._indexColor - 1) % SettingColor.PawnColors.Count;
            this.ColorValue = SettingColor.PawnColors[this._indexColor];
        }

        /// <summary>
        /// Cherche la couleur suivante
        /// </summary>
        public void NextColorRight()
        {
            this._indexColor = (this._indexColor + 1) % SettingColor.PawnColors.Count;
            this.ColorValue = SettingColor.PawnColors[this._indexColor];
        }
    }
}
