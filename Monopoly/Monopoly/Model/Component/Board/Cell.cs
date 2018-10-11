using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Monopoly.Model.Component.Board
{
    /// <summary>
    /// Réprésente une case du plateau de jeux
    /// </summary>
    public class Cell
    {
        private string _title;
        private int _id;        

        /// <summary>
        /// Crée une instance de la classe : Square
        /// </summary>
        /// <param name="title">Titre de la case</param>
        /// <param name="id">Identifiant</param>
        public Cell(string title, int id)
        {
            this._title = title;
            _id = id;
        }

        /// <summary>
        /// Titre de la case
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        /// Identifiant de la case
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
