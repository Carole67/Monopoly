using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string ColorValue { get; private set; }

        /// <summary>
        /// Création d'un pion
        /// </summary>
        /// <param name="colorValue">Couleur du pion</param>
        public Pawn(string colorValue)
        {
            this.ColorValue = colorValue;
        }

    }
}
