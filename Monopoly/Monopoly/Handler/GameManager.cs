using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Handler.Entity;

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

        private static GameManager _instance = null;
        
        /// <summary>
        /// Création du gestionaire princiaple (Façade)
        /// </summary>
        private GameManager()
        {
            this.boardHandler = BoardHandler.Instance;
            this.cardHandler = CardHandler.Instance;
            this.playerHandler = PlayerHandler.Instance;
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
    }
}
