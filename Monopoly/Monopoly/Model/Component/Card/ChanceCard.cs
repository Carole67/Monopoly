using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Monopoly.Model.Component.Entity;

namespace Monopoly.Model.Component.Card
{
    [Serializable]
    [XmlRoot("ChanceCard")]
    public class ChanceCard : Entity.Card
    {
        /// <summary>
        /// Création d'une carte chance
        /// </summary>
        public ChanceCard() { }

    }
}
