using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Model.Component.Board;
using Monopoly.Handler;
namespace Monopoly.Model.Component.Entity
{
    public class Card
    {
        private int _id;
        private string _description;
        private string _icon;
        private string _title;
        private int _eventType;

        public const int EVENT_MOVE = 0;
        public const int EVENT_PENALITY = 1;
        public const int EVENT_RELEASE_JAIL = 2;
        public const int EVENT_PROFIT = 3;
        public const int EVENT_GOTO_JAIL = 4;
        public const int EVENT_MOVE_AND_PROFIT = 5;

        /// <summary>
        /// Création d'une carte
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="tite">Titre</param>
        /// <param name="description">Description</param>
        /// <param name="icon">Icon</param>
        /// <param name="eventType">Evenement</param>
        public Card(int id, string tite, string description, string icon, int eventType)
        {
            _id = id;
            _title = tite;
            _description = description;
            _icon = icon;
            _eventType = eventType;
        }

        /// <summary>
        /// Identifiant de la carte
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Titre de la carte
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        /// Déscription de la carte
        /// </summary>
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>
        /// Icon de la carte
        /// </summary>
        public string Icon
        {
            get { return _icon; }
            set { _icon = value; }
        }

        /// <summary>
        /// Type de l'evenement
        /// </summary>
        public int EventType
        {
            get { return _eventType; }
            set { _eventType = value; }
        }


    }
}
