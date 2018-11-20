using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Model.Component.Cells;
using Monopoly.Model.Component.Cards;

namespace Monopoly.Model.Component
{
    /// <summary>
    /// Classe Joueur
    /// </summary>
    public class Player
    {
        #region Constantes
        public const int WAITING = 0;
        public const int PLAYING = 1;
        public const int BUILD_HOTEL = 1;
        public const int BUILD_HOUSE = 2;
        #endregion
        #region Variables
        public int Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public bool InJail { get; set; }
        public int Position { get; private set; }
        public Pawn Pawn { get; set; }
        public List<Card> ListOfCards { get; private set; }
        public List<Property> ListOfPoperties { get; private set; }
        #endregion
        #region Constructeurs
        /// <summary>
        /// Crée une instance de la classe
        /// </summary>
        public Player()
        {
            this.Id = 1;
            this.Name = "";
            this.Pawn = new Pawn();
            this.ListOfCards = new List<Card>();
            this.ListOfPoperties = new List<Property>();
        }

        /// <summary>
        /// Crée une instance de la classe
        /// </summary>
        /// <param name="id">Identifiant</param>
        /// <param name="name">Nom du joueur</param>
        /// <param name="pawn">Pion du joueurs</param>
        public Player(int id, string name, Pawn pawn)
        {
            this.Id = id;
            this.Name = name;
            this.Pawn = pawn;
            this.ListOfCards = new List<Card>();
            this.ListOfPoperties = new List<Property>();
        }
        #endregion
        #region Methodes publique
        /// <summary>
        /// Ajoute une propriété à sa liste de biens
        /// </summary>
        /// <param name="property">Porpriete</param>
        public void AddPorperty(Property p)
        {
            this.ListOfPoperties.Add(p);
        }

        /// <summary>
        /// Enlève une propriété à sa la liste de bien
        /// </summary>
        /// <param name="p">Propriété</param>
        public void RemoveProperty(Property p)
        {
            this.ListOfPoperties.Remove(p);
        }

        /// <summary>
        /// Ajoute une carte à sa liste de cartes
        /// </summary>
        /// <param name="c">Carte</param>
        public void AddCard(Card c)
        {
            this.ListOfCards.Add(c);
        }

        /// <summary>
        /// Enlève une carte à sa liste de cartes
        /// </summary>
        /// <param name="c">Carte</param>
        public void RemoveCard(Card c)
        {
            this.ListOfCards.Remove(c);
        }
        /// <summary>
        /// Deplace le joueurs à la position cible
        /// </summary>
        /// <param name="nb">Nombre de deplacement</param>
        public void MoveTo(int position)
        {
            this.Position = position;
        }

        /// <summary>
        /// Deplace le joueur sur une case cible
        /// </summary>
        /// <param name="cell">Case du plateau</param>
        public void MoveTo(Cell cell)
        {
            this.Position = cell.Id;
        }
        #endregion


    }
}
