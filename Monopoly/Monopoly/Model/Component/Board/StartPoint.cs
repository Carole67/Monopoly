﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Monopoly.Model.Component.Board
{
    [Serializable]
    [XmlRoot("StartPoint")]
    public class StartPoint : Cell
    {
        [XmlElement("Logo")]
        public string Logo { get; set; }
        [XmlElement("Description")]
        public string Description { get; set; }

        /// <summary>
        /// Création d'une case "Départ"
        /// </summary>
        public StartPoint() { }
    }
}
