using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Monopoly.Model.Component.Cells
{
    [Serializable]
    [XmlRoot("LandGroup")]
    public class LandGroup
    {
        #region Variables
        [XmlElement("IdGroup")]
        public int IdGroup { get; set; }
        [XmlElement("Color")]
        public string Color { get; set; }
        [XmlElement("HotelPrice")]
        public int HotelPrice { get; set; }
        [XmlElement("HousePrice")]
        public int HousePrice { get; set; }
        #endregion

        #region Constructeur
        /// <summary>
        /// Création du goupe de terrains
        /// </summary>
        public LandGroup()
        {

        }
        #endregion

    }
}
