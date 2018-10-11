using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Model.Component.Board
{
    class Jail : Cell
    {
        private string _logo;

        /// <summary>
        /// Création d'une prison
        /// </summary>
        /// <param name="title">titre</param>
        /// <param name="id">id</param>
        /// <param name="logo">logo</param>
        public Jail(string title, int id, string logo) : base(title, id)
        {
            _logo = logo;
        }

        /// <summary>
        /// Logo de la prison
        /// </summary>
        public string Logo
        {
            get { return _logo; }
            set { _logo = value; }
        }
    }
}
