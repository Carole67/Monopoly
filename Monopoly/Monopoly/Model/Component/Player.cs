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
        public int Position { get; set; }
        public Pawn Pawn { get; set; }
        public List<Card> ListOfCards { get; set; }
        public List<Property> ListOfPoperties { get; set; }
        #endregion 

        /// <summary>
        /// Création d'une instance de la classe
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
        /// Création d'une instance de la classe
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
       
        /// <summary>
        /// Donne de l'argent à un autre joueur
        /// </summary>
        /// <param name="p"></param>
        /// <param name="money"></param>
        public void GiveMoneyTo(Player player, int money)
        {
            //todo
        }

        /// <summary>
        /// Donne une properete à un joueur
        /// </summary>
        /// <param name="player"></param>
        /// <param name="property"></param>
        public void GivePropertyTo(Player player, Property property)
        {
            //todo
        }

        /// <summary>
        /// Construit une Maison/Hotel sur une propriete
        /// </summary>
        /// <param name="p">Joueur</param>
        /// <param name="typeConstruction">Type de construction</param>
        public void BuildConstruction(Property p, int typeConstruction)
        {
            if(PlayerOwnProperty(p))
            {
                switch (typeConstruction)
                {
                    case BUILD_HOUSE:
                    
                        break;
                    case BUILD_HOTEL:
                        break;
                    default:
                        break;
                }
            }
            
            
        }

        /// <summary>
        /// Verifie que le joueur possède bien la propriété
        /// </summary>
        /// <param name="property">Propriete</param>
        /// <returns>Boolean</returns>
        private bool PlayerOwnProperty(Property property)
        {
            Predicate<Property> findProperty = (Property p) => { return p.Id == property.Id; };
            return (ListOfPoperties.Find(findProperty) != null);

        }

        /// <summary>
        /// Deplace le joueurs de N case
        /// </summary>
        /// <param name="nb">Nombre de deplacement</param>
        public void MoveTo(int nb)
        {
            this.Position = (this.Position + nb) % Board.Instance.ListCell.Count;
        }

        /// <summary>
        /// Deplace le joueur sur une case precice
        /// </summary>
        /// <param name="cell">Case du plateau</param>
        public void MoveTo(Cell cell)
        {
            this.Position = cell.Id;
        }

    }
}
