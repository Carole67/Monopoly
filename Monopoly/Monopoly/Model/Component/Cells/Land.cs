using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Monopoly.Model.Component.Cells
{
    [Serializable]
    [XmlRoot("Land")]
    public class Land : Property
    {
        [XmlElement("LandGroup")]
        public LandGroup LandGroup { get; set; }
        [XmlArray("RantalList")]
        [XmlArrayItem("Rantal")]
        public List<int> RantalList { get; set; }

        [XmlIgnore]
        private int _nbHouse;
        [XmlIgnore]
        private int _nbHotel;
        /// <summary>
        /// Création d'une case "Terrain"
        /// </summary>
        public Land()
        {
            _nbHotel = 0;
            _nbHouse = 0;
        }


        /// <summary>
        /// Construit une maison/hotel sur le terrain
        /// </summary>
        public void BuildConstruction()
        {
            if (_nbHouse > 4)
            {
                _nbHotel += 1;
            }
            else
            {
                _nbHouse += 1;
            }
        }

        /// <summary>
        /// Nombre d'hotel sur le terrain
        /// </summary>
        public int NbHotel
        {
            get { return _nbHotel; }
        }

        /// <summary>
        /// Nombre de maison sur le terrain
        /// </summary>
        public int NbHouse
        {
            get { return _nbHouse; }
        }
    }
}
