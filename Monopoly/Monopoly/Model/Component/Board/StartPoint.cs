using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Model.Component.Board
{

    class StartPoint : Cell
    {
        private string _logo;
        private string _description;

        /// <summary>
        /// Création de la case départ
        /// </summary>
        /// <param name="title">titre</param>
        /// <param name="id">id</param>
        /// <param name="logo">logo</param>
        /// <param name="description">description</param>
        public StartPoint(string title, int id, string logo, string description) : base(title, id)
        {
            _logo = logo;
        }

        /// <summary>
        /// Logo de la case départ
        /// </summary>
        public string Logo
        {
            get { return _logo; }
            set { _logo = value; }
        }

        /// <summary>
        /// Description de la case départ
        /// </summary>
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

    }
}
