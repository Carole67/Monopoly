using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Model.Component.Player;
using Monopoly.Model.Component.Board;

namespace Monopoly.Model.Component.Entity
{
    public class Player
    {
        public const int WAITING = 0;
        public const int PLAYING = 1;

        private string _firtName;
        private string _lastName;
        private int _money;
        private int _status;
        private bool _inJail;
        private Pawn _pawn;
        private List<Card> _cards;
        private List<Property> _properties;
        
        /// <summary>
        /// Création d'un joueurs
        /// </summary>
        /// <param name="firtName"></param>
        /// <param name="lastName"></param>
        /// <param name="pawn"></param>
        public Player(string firtName, string lastName, Pawn pawn)
        {
            _firtName = firtName;
            _lastName = lastName;
            _pawn = pawn;
            _cards = new List<Card>();
        }

        /// <summary>
        /// Prénom du joueur
        /// </summary>
        public string FirstName
        {
            get { return _firtName; }
            set { _firtName = value; }
        }

        /// <summary>
        /// Nom du joueur
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        /// <summary>
        /// Argent du joueur
        /// </summary>
        public int Money
        {
            get { return _money; }
            set { _money = value; }
        }

        /// <summary>
        /// Status du joueur
        /// </summary>
        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public bool InJail
        {
            get { return _inJail; }
            set { _inJail = value; }
        }
        /// <summary>
        /// Pion du joueur
        /// </summary>
        public Pawn Pawn
        {
            get { return _pawn; }
            set { _pawn = value; }
        }

        /// <summary>
        /// Liste des carte que possède le joueur
        /// </summary>
        public List<Card> Cards
        {
            get { return _cards; }
        }

        /// <summary>
        /// Ajoute une carte la liste des cartes que possède le joueur
        /// </summary>
        /// <param name="card">Carte à ajouter</param>
        public void AddCard(Card card)
        {
            _cards.Add(card);
        }

        /// <summary>
        /// Supprime une carte du joueurs
        /// </summary>
        /// <param name="card">Carte à supprimer</param>
        public void RemoveCard(Card card)
        {
            Predicate<Card> findCard = (Card c) => { return c.Id == card.Id; };
            _cards.RemoveAll(findCard);
            
        }

        /// <summary>
        /// Liste des propriétées du joueurs
        /// </summary>
        public List<Property> Properties
        {
            get { return _properties; }
        }

        /// <summary>
        /// Ajoute une propriétée au joueur
        /// </summary>
        /// <param name="property">Propriété à ajouter</param>
        public void AddProperty(Property property)
        {
            _properties.Add(property);
        }

        /// <summary>
        /// Supprime une propriété du joueur
        /// </summary>
        /// <param name="property">Propriété à supprimer</param>
        public void RemoveProperty(Property property)
        {
            Predicate<Property> findProperty = (Property p) => { return p.Position == property.Position; };
            _properties.RemoveAll(findProperty);
        }

    }
}
