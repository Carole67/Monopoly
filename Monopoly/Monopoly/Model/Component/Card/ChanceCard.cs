using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Model.Component.Entity;

namespace Monopoly.Model.Component.Card
{
    class ChanceCard : Entity.Card
    {
        /// <summary>
        /// Création d'une carte chance
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tite"></param>
        /// <param name="description"></param>
        /// <param name="icon"></param>
        /// <param name="eventType"></param>
        public ChanceCard(int id, string tite, string description, string icon, int eventType) : base(id, tite, description, icon, eventType) { }
    }
}
