
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Handler.Entity;
using Monopoly.Model.Component;
using Monopoly.Model.Component.Cells;

namespace Monopoly.Handler
{
    /// <summary>
    ///  Gestionnaire principal (Façade)
    /// </summary>
    public class GameManager
    {
        /// <summary>
        /// Gestionaire du plateau
        /// </summary>
        public BoardHandler boardHandler { get; private set; }

        /// <summary>
        /// Gestionnaire de cartes
        /// </summary>
        public CardHandler cardHandler { get; private set; }

        /// <summary>
        /// Gestionaire de joueurs
        /// </summary>
        public PlayerHandler playerHandler { get; private set; }


        public Dice FirstDice;
        public Dice SecondeDice;
        private static int NbPlayer;


        private static GameManager _instance = null;
        
        /// <summary>
        /// Création du gestionaire princiaple (Façade)
        /// </summary>
        private GameManager()
        {
            this.boardHandler = BoardHandler.Instance;
            this.cardHandler = CardHandler.Instance;
            this.playerHandler = PlayerHandler.Instance;
            FirstDice = new Dice();
            SecondeDice = new Dice();
            NbPlayer = 0;
        }

        /// <summary>
        /// Retourne l'instance du gestionnaire
        /// </summary>
        public static GameManager Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new GameManager();
                }
                return _instance;
            }
        }

        /// <summary>
        /// Création du joueur courrant
        /// </summary>
        /// <param name="pseudo">Pseudo du joueur</param>
        /// <param name="colorValue">Couleur du joueur</param>
        public void CreateSinglePlayer(string pseudo, string colorValue)
        {
            NbPlayer += 1;
            Random rand = new Random();

            Console.WriteLine("generation d'un id " + NbPlayer);
            PlayerHandler.Instance.AddPlayer(new Player(NbPlayer, pseudo, new Pawn(colorValue)) );          
            
        }

        /// <summary>
        /// Achète une propriété
        /// </summary>
        /// <param name="property">Propriété</param>
        public void BuyProperty(Property property)
        {
            //TODO
            /*
            if(NobodyOwnProperty(property))
            {
                playerHandler.BuyProperty(playerHandler.GetCurrentPlayer(), property);
            }
            else
            {
                Player p = playerHandler.GetOwnerOfProperty(property);
                playerHandler.BuyPropertyTo(playerHandler.GetCurrentPlayer(), p, property);
            }
            */
        }

        public void RoolDice()
        {
            //TODO
            int value = (FirstDice.Value + SecondeDice.Value) % this.boardHandler.Board.ListCell.Count;
        }
    }
}
