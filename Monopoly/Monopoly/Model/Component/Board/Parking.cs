using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Monopoly.Model.Component.Board
{
    public class Parking : Cell
    {
        private string _logo;

        /// <summary>
        /// Création du parking
        /// </summary>
        /// <param name="title">titre</param>
        /// <param name="id">id</param>
        /// <param name="logo">logo</param>
        public Parking(string title, int id, string logo) : base(title, id)
        {
            _logo = logo;
        }

        /// <summary>
        /// Logo du parking
        /// </summary>
        public string Logo
        {
            get { return _logo; }
            set { _logo = value; }
        }
    }
}
