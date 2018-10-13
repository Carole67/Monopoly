using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Model.Component.Board;
using Monopoly.Handler;
using System.Xml.Serialization;

namespace Monopoly.Model.Component.Entity
{
    [Serializable]
    public class Card
    {
        [XmlElement("Id")]
        public int Id { get; set; }
        [XmlElement("Description")]
        public string Description { get; set; }
        [XmlElement("Icon")]
        public string Icon { get; set; }
        [XmlElement("Title")]
        public string Title { get; set; }
        [XmlElement("EventType")]
        public int EventType { get; set; }

        public const int EVENT_MOVE = 0;
        public const int EVENT_PENALITY = 1;
        public const int EVENT_RELEASE_JAIL = 2;
        public const int EVENT_PROFIT = 3;
        public const int EVENT_GOTO_JAIL = 4;
        public const int EVENT_MOVE_AND_PROFIT = 5;

        /// <summary>
        /// Création d'une carte
        /// </summary>
        public Card() { }
    }
}
