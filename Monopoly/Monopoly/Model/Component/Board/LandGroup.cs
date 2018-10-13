using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Monopoly.Model.Component.Board
{
    [Serializable]
    [XmlRoot("LandGroup")]
    public class LandGroup
    {
        [XmlElement("IdGroup")]
        public int IdGroup { get; set; }
        [XmlElement("Color")]
        public string Color { get; set; }
        [XmlElement("HotelPrice")]
        public int HotelPrice { get; set; }
        [XmlElement("HousePrice")]
        public int HousePrice { get; set; }

        /// <summary>
        /// Création du goupe de terrains
        /// </summary>
        public LandGroup() { }
    }
}
