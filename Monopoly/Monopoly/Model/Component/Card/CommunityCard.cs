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
    [XmlRoot("CommunityCard")]
    public class CommunityCard : Entity.Card
    {
        /// <summary>
        /// Cration d'une carte communauté
        /// </summary>
        public CommunityCard() { }

    }
}
