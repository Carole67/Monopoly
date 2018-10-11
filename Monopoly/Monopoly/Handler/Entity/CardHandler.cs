using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Model.Component.Entity;

namespace Monopoly.Handler.Entity
{
    class CardHandler
    {
        private static CardHandler _instance = null;
        private static List<Card> _listCards { get; set; }
        
        /// <summary>
        /// Cration du gestionnaire de carte
        /// </summary>
        private CardHandler()
        {
            // TODO
            _listCards = new List<Card>();
        }

        /// <summary>
        /// Instance du gestionnaire de cartes
        /// </summary>
        public static CardHandler Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new CardHandler();
                }
                return _instance;
            }
        }

        
    }
}
