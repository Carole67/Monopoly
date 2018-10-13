using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Monopoly.Model.Component.Board;

namespace Monopoly.Model.Component.Entity
{
    [Serializable]
    [XmlRoot("Board")]
    public class Board
    {
        [XmlElement("Cell")]
        public List<Cell> ListCell { get; set; }

        /// <summary>
        /// Création du plateau
        /// </summary>
        public Board()
        {
            this.ListCell = new List<Cell>();
        }
    }
}
