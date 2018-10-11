using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Model.Component.Board
{
    /// <summary>
    /// Représente une case : Gare
    /// </summary>
    public class TrainStation : Property
    {
        private string _logo;

        /// <summary>
        /// Création d'une gare
        /// </summary>
        /// <param name="title">Titre</param>
        /// <param name="purchasePrice">Prix d'achat</param>
        /// <param name="mortgagePrice">Prix d'hypotèque</param>
        /// <param name="status">status</param>
        /// <param name="logo">logo</param>
        public TrainStation(string title, int purchasePrice, int mortgagePrice, int status, string logo) : base(title, purchasePrice, mortgagePrice, status)
        {
            this._logo = logo;
        }

        /// <summary>
        /// Représente le logo de la gare
        /// </summary>
        public string Logo
        {
            get { return _logo; }
            set { _logo = value; }
        }


    }
}
