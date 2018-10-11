using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Model.Component.Board
{
    /// <summary>
    /// Représente une case : terrain
    /// </summary>
    public class Land : Property
    {
        private LandGroup _landGroup;
        private List<int> _rantalList;

        /// <summary>
        /// Création d'un terrain
        /// </summary>
        /// <param name="title">Titre du terrain</param>
        /// <param name="price">Prix d'achat</param>
        /// <param name="landGroup">Groupe du terrain</param>
        public Land(string title, int id, int purchasePrice, int mortgagePrice, int status, LandGroup landGroup, List<int> rantalList) : base(title, id, purchasePrice, mortgagePrice, status)
        {
            this._landGroup = landGroup;
            this._rantalList = rantalList;
        }

        /// <summary>
        /// Groupe du terrain
        /// </summary>
        public LandGroup Group
        {
            get { return _landGroup; }
            set { _landGroup = value; }
        }

        /// <summary>
        /// Liste des loyer
        /// </summary>
        public List<int> RantalList
        {
            get { return _rantalList; }
            set { _rantalList = value; }
        }
    }
}
