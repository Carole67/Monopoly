using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Model.Component.Entity;
namespace Monopoly.Model.Component.Card
{
    public class CommunityCard : Entity.Card
    {

        /// <summary>
        /// Création d'une carte caisse de communoté
        /// </summary>
        /// <param name="id">identifiant</param>
        /// <param name="title">Titre/param>
        /// <param name="description">Description</param>
        /// <param name="icon">Icon</param>
        public CommunityCard(int id, string title, string description, string icon, int eventType) : base(id, title, description, icon, eventType){}

    }
}
