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
        #region Variables
        [XmlElement("LandGroup")]
        public LandGroup LandGroup { get; set; }
        [XmlArray("RantalList")]
        [XmlArrayItem("Rantal")]
        public List<int> RantalList { get; set; }
        [XmlIgnore]
        public int NbHotel { get; private set; }
        [XmlIgnore]
        public int NbHouse { get; private set; }
        #endregion

        #region Constructeur
        /// <summary>
        /// Création d'une case "Terrain"
        /// </summary>
        public Land()
        {
            NbHouse = 0;
            NbHotel = 0;
        }
        #endregion

        #region Méthode publique
        /// <summary>
        /// Construit une maison sur le terrain
        /// </summary>
        public void BuildHouse(int nbHouse)
        {
            if ((this.NbHouse + nbHouse) > 4)
            {
                BuildHotel();
            }
            else
            {
                this.NbHouse += nbHouse;
            }
        }

        /// <summary>
        /// Construit un hotel sur le terrain
        /// </summary>
        public void BuildHotel()
        {
            this.NbHouse = 0;
            this.NbHotel = 1;
        }

        /// <summary>
        /// Récupère le prix du loyer
        /// </summary>
        /// <returns></returns>
        public int GetRental()
        {
            if (NbHotel > 0)
            {
                return RantalList[NbHotel + 4];
            }
            else
            {
                return RantalList[NbHouse];
            }
        }
        #endregion
    }
}
