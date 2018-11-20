using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Monopoly.Model.Component.Cells
{
    [Serializable]
    [XmlRoot("Property")]
    [XmlInclude(typeof(Land))]
    [XmlInclude(typeof(PublicService))]
    [XmlInclude(typeof(TrainStation))]
    public class Property : Cell
    {
        #region Constantes
        [XmlIgnore]
        public const int AVAILABLE_ON_SALE = 1;
        [XmlIgnore]
        public const int NOT_AVAILABLE_ON_SALE = 2;
        #endregion

        #region Variables
        [XmlElement("Status")]
        public int status;
        [XmlElement("PurchasePrice")]
        public int PurchasePrice { get; set; }
        [XmlElement("MortgagePrice")]
        public int MortgagePrice { get; set; }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Création d'une case "Propriete"
        /// </summary>
        public Property()
        {
           status = AVAILABLE_ON_SALE;
        }
        #endregion

    }
}
