using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Model.Component.Board
{
    /// <summary>
    /// Case service public
    /// </summary>
    public class PublicService : Property
    {
        private string _logo;

        /// <summary>
        /// Création d'un service Public
        /// </summary>
        /// <param name="title">Titre</param>
        /// <param name="id">id</param>
        /// <param name="purchasePrice">Prix d'achat</param>
        /// <param name="mortgagePrice">Prix d'hypotèque</param>
        /// <param name="status">status</param>
        /// <param name="logo">logo</param>
        public PublicService(string title, int id, int purchasePrice, int mortgagePrice, int status, string logo) : base(title, id, purchasePrice, mortgagePrice, status)
        {
            this._logo = logo;
        }

        /// <summary>
        /// Logo du service public
        /// </summary>
        public string Logo
        {
            get { return _logo; }
            set { _logo = value; }
        }
    }
}
