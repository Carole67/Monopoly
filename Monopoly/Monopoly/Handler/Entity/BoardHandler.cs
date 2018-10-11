using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Model.Component.Entity;

namespace Monopoly.Handler.Entity
{
    class BoardHandler
    {
        private static BoardHandler _instance = null;
        private static Board _board { get; set; }

        /// <summary>
        /// Création du gestionaire du Plateau
        /// </summary>
        private BoardHandler()
        {
            _board = Board.Instance;
        }

        /// <summary>
        /// Instance du gestionnaire du plateau
        /// </summary>
        public static BoardHandler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BoardHandler();
                }
                return _instance;
            }
        }

    }
}
