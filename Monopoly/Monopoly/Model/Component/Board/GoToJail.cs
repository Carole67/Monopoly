using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Model.Component.Board
{
    [Serializable]
    public class GoToJail : Cell
    {
        private string _logo;

        /// <summary>
        /// Création de la case : aller en prison
        /// </summary>
        /// <param name="title">titre</param>
        /// <param name="id">id</param>
        /// <param name="logo">logo</param>
        public GoToJail(string title, int id, string logo) : base(title, id)
        {
            _logo = logo;
        }

        /// <summary>
        /// Logo du policier
        /// </summary>
        public string Logo
        {
            get { return _logo; }
            set { _logo = value; }
        }
    }
}
