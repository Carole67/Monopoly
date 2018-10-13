using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Handler.Entity;

namespace Monopoly.Handler
{
    /// <summary>
    /// Jeux Monopoly
    /// </summary>
    public class Game
    {
        public static Game _instance = null;
        private HandlerPlayer _handlerPlayer;
        private BoardHandler _boardHandler;
        private CardHandler _cardHandler;
        private Bank _bank;
        private int _round;       
        

       
        /// <summary>
        /// Crée l'instance du jeux Monopoly
        /// </summary>
        private Game()
        {            
            this._handlerPlayer = HandlerPlayer.Instance;
            this._boardHandler = BoardHandler.Instance;
            this._cardHandler = CardHandler.Instance;
            this._bank = Bank.Instance;
        }


        /// <summary>
        /// Récupère l'unique instance de la classe : Game
        /// </summary>
        public static Game Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Game();
                }
                return _instance;
            }            
        }

        /// <summary>
        /// Récupère l'instance du gestionnaire de joueur
        /// </summary>
        public HandlerPlayer HandlerPlayer
        {
            get { return _handlerPlayer; }
        }

        /// <summary>
        /// Récupère l'instance de la banque
        /// </summary>
        public Bank Bank
        {
            get { return _bank; }
        }

        /// <summary>
        /// Gestionnaire de carte
        /// </summary>
        public CardHandler CardHandler
        {
            get { return _cardHandler; }
        }
        /// <summary>
        /// Gestionnaire du plateau
        /// </summary>
        public BoardHandler BoardHandler
        {
            get { return _boardHandler; }
        }

        /// <summary>
        /// Nombre de tour dans le jeux
        /// </summary>
        public int Round
        {
            get { return _round; }
            set { _round = value; }
        }
    }
}
