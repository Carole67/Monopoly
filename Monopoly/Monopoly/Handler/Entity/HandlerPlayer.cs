using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Model.Component.Entity;
namespace Monopoly.Handler
{
    /// <summary>
    /// Gestionnaire de joueurs
    /// </summary>
    public class HandlerPlayer 
    {
        private static HandlerPlayer _instance = null;
        private List<Player> _players;

        /// <summary>
        /// Constructeur de la classe : HandlerPlayer
        /// </summary>
        public HandlerPlayer() { }


        /// <summary>
        /// Récupère l'unique instance de la classe : HandlerPlayer
        /// </summary>
        public static HandlerPlayer Instance
        {
            get
            {
                if (Instance == null)
                {
                    _instance = new HandlerPlayer();
                }
                return _instance;
            }
        }

        public Player GetCurrentPlayer()
        {
            Predicate<Player> findPlayer = (Player p) => { return p.Status == Player.PLAYING; };
            return _players.Find(findPlayer);
        }
    }
}
