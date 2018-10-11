using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Model.Component.Entity;
namespace Monopoly.Model.Component.Board
{
    class DrawCard : Cell
    {
        private string _icon;
        private int _type;

        public const int TYPE_CHANCE = 0;
        public const int TYPE_COMMUNITY_SERVICE = 1;


        /// <summary>
        /// Case de pioche
        /// </summary>
        /// <param name="title">titre</param>
        /// <param name="id">id</param>
        /// <param name="type">type</param>
        /// <param name="icon">icon</param>
        public DrawCard(string title, int id, int type, string icon) : base(title, id)
        {
            _type = type;
            _icon = icon;
        }

        /// <summary>
        /// Icon de la case
        /// </summary>
        public string Icon
        {
            get { return _icon; }
            set { _icon = value; }
        }

        /// <summary>
        /// Type de la case
        /// </summary>
        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }

        
    }
}
