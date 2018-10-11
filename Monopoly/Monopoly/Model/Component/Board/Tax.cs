using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Model.Component.Board
{
    public class Tax : Cell
    {
        private string _logo;
        private int _amount;

        /// <summary>
        /// Création d'une prison
        /// </summary>
        /// <param name="title">titre</param>
        /// <param name="id">id</param>
        /// <param name="logo">logo</param>
        public Tax(string title, int id, string logo, int amount) : base(title, id)
        {
            _logo = logo;
            _amount = amount;

        }

        /// <summary>
        /// Logo de la prison
        /// </summary>
        public string Logo
        {
            get { return _logo; }
            set { _logo = value; }
        }

        /// <summary>
        /// Montant de la tax
        /// </summary>
        public int amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
    }
}
