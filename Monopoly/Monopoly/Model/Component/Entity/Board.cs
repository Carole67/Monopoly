using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Model.Component.Board;

namespace Monopoly.Model.Component.Entity
{
    public class Board
    {
        private static Board _instance = null;
        private List<Cell> _cells;

        /// <summary>
        /// Création du plateau
        /// </summary>
        /// <param name="cells"></param>
        private Board()
        {
            this._cells = new List<Cell>();
        }

        /// <summary>
        /// Instance du plateau
        /// </summary>
        public static Board Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Board();
                }
                return _instance;
            }
        }

        /// <summary>
        /// Liste des case présent sur le plateau
        /// </summary>
        public List<Cell> Cells
        {
            get { return _cells; }
            set { _cells = value; }
        }


    }
}
