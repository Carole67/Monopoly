using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Monopoly.Model.Component.Cells;

namespace Monopoly.Model.Component
{
    [Serializable]
    [XmlRoot("Board")]
    public class Board
    {
        [XmlIgnore]
        private static Board _instance = null;
        [XmlElement("Cell")]
        public List<Cell> ListCell { get; set; }

        /// <summary>
        /// Création du plateau
        /// </summary>
        private Board()
        {
            this.ListCell = new List<Cell>();
        }

        /// <summary>
        /// Retourne l'unique instance de la classe
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

        public Cell GetCell(int index)
        {
            Predicate<Cell> filtreCell = (Cell c) => { return c.Id == index; };
            return ListCell.Find(filtreCell);
        }
    }
}
