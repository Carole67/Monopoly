using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Monopoly.Model.Component.Entity;
namespace Monopoly.Model.Component.Board
{
    [Serializable]
    [XmlRoot("DrawCard")]
    public class DrawCard : Cell
    {
        [XmlElement("Icon")]
        public string Icon { get; set; }
        [XmlElement("Type")]
        public int Type { get; set; }

        [XmlIgnore]
        public const int TYPE_CHANCE = 0;
        [XmlIgnore]
        public const int TYPE_COMMUNITY_SERVICE = 1;

        /// <summary>
        /// Création d'une case de pioche
        /// </summary>
        public DrawCard() { }        
    }
}
