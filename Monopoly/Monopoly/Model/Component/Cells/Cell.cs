using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Monopoly.Model.Component.Cells
{
    [Serializable]
    [XmlRoot("Cell")]
    [XmlInclude(typeof(DrawCard))]
    [XmlInclude(typeof(GoToJail))]
    [XmlInclude(typeof(Jail))]
    [XmlInclude(typeof(Property))]
    [XmlInclude(typeof(Parking))]
    [XmlInclude(typeof(StartPoint))]
    [XmlInclude(typeof(Tax))]
    public class Cell
    {
        [XmlElement("Id")]
        public int Id { get; set; }
        [XmlElement("Title")]
        public string Title { get; set; }

        /// <summary>
        /// Création d'une cell
        /// </summary>
        public Cell() { }
    }
}
