using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Settings;
namespace Monopoly.Model.Component
{
    /// <summary>
    /// Pion
    /// </summary>
    public class Pawn
    {

        /// <summary>
        /// Couleur du pion
        /// </summary>
        public string ColorValue { get; set; }

        /// <summary>
        /// Création d'une instance de la classe
        /// </summary>
        public Pawn()
        {
            this.ColorValue = "#000";
        }
        /// <summary>
        /// Création d'une instance de la classe
        /// </summary>
        /// <param name="colorName">Index de la couleur</param>
        public Pawn(int colorIndex)
        {            
            this.ColorValue = ( (colorIndex < SettingColor.PawnColors.Count) && (colorIndex > 0 )) ? SettingColor.PawnColors[colorIndex] : "#000";
        }

    }
}
