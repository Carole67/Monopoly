using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Model.Component.Entity;

namespace Monopoly.Handler.Entity
{
    public class BoardHandler
    {
        private static BoardHandler _instance = null;
        private Board _board;

        /// <summary>
        /// Création du gestionaire du Plateau
        /// </summary>
        private BoardHandler()
        {
            this.Board = Handler.Service.XmlDataAccess.XMLDeserializeObject<Board>(Handler.Config.filePath_XmlBoard);
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

        /// <summary>
        /// Instance du plateau
        /// </summary>
        public Board Board
        {
            get { return this._board; }
            set { this._board = value; }
        }
    }
}
