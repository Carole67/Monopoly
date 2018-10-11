using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Model.Component.Board
{
    /// <summary>
    /// Groupe d'un terrain
    /// </summary>
    public class LandGroup
    {
        private string _color;
        private int _hotelPrice;
        private int _housePrice;

        /// <summary>
        /// Crée une instance de la classe : LandGroup
        /// </summary>
        /// <param name="color">Couleur du groupe</param>
        public LandGroup(string color)
        {
            this._color = color;
        }

        /// <summary>
        /// Couleur du groupe de terrain
        /// </summary>
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        /// <summary>
        /// Prix d'un hotel
        /// </summary>
        public int HotelPrice
        {
            get { return _hotelPrice; }
            set { _hotelPrice = value; }
        }

        /// <summary>
        /// Prix d'une maison
        /// </summary>
        public int HousePrice
        {
            get { return _housePrice; }
            set { _housePrice = value; }
        }
    }
}
