using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Monopoly.Model.Component.Board
{
    /// <summary>
    /// Réprésente une case de type propriété
    /// </summary>    
    public class Property : Cell
    {
        private int _purchasePrice;
        private int _mortgagePrice;
        private int _status;
        
        public const int STATUS_SOLD = 1;
        public const int STATUS_MONTAGAGE = 2;
        public const int STATUS_AVAILABLE = 3;
        
        /// <summary>
        /// Création d'une prorpiété
        /// </summary>
        /// <param name="title">titre</param>
        /// <param name="id">id</param>
        /// <param name="purchasePrice">prix d'achat</param>
        /// <param name="mortgagePrice">prix d'hypotèque</param>
        /// <param name="status">status</param>
        public Property(string title, int id, int purchasePrice, int mortgagePrice, int status) : base(title, id)
        {
            this._purchasePrice = purchasePrice;
            _status = status;
        }

        /// <summary>
        /// Prix d'achat de la propriété 
        /// </summary>
        public int PurchasePrice
        {
            get { return _purchasePrice; }
            set { _purchasePrice = value; }
        }

        /// <summary>
        /// Status de la propriété
        /// </summary>
        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        /// Prix d'hypotèque
        /// </summary>
        public int MortgagePrice
        {
            get { return _mortgagePrice; }
            set { _mortgagePrice = value; }
        }

    }
}
