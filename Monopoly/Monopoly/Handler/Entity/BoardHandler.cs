using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Model.Component;
using Monopoly.Settings;
using Monopoly.Service.Xml;
using Monopoly.Model.Component.Cells;

namespace Monopoly.Handler.Entity
{
    public class BoardHandler
    {
        /// <summary>
        /// Instance du gestionaire de plateau
        /// </summary>
        private static BoardHandler _instance = null;
        
        /// <summary>
        /// Plateau
        /// </summary>
        private Board _board;

        /// <summary>
        /// Création du gestionaire du Plateau
        /// </summary>
        private BoardHandler()
        {
            this.Board = XmlDataAccess.XMLDeserializeObject<Board>(Config.filePath_XmlBoard);
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

        public string getColor(Cell c)
        {
            if (c is Land)
            {
                Land terrain = (Land)c;
                return terrain.LandGroup.Color;
            }
            return "#FFF";               

        }
    }
}
