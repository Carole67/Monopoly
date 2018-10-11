using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Model.Component.Player
{
    /// <summary>
    /// Pion
    /// </summary>
    public class Pawn
    {
        private string _color;
        private string _picture;

        /// <summary>
        /// Création d'un pion
        /// </summary>
        /// <param name="color">Couleur du pion</param>
        /// <param name="picture">Image de fond</param>
        public Pawn(string color, string picture)
        {
            _color = color;
            _picture = picture;
        }

        /// <summary>
        /// Couleur du pion
        /// </summary>
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }


        /// <summary>
        /// Image du pion
        /// </summary>
        public string Picture
        {
            get { return _picture; }
            set { _picture = value; }
        }
    }
}
