using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Model.Component;

namespace Monopoly.Handler.Entity
{
    /// <summary>
    /// Gestionnaire de joueurs
    /// </summary>
    public class PlayerHandler 
    {
        /// <summary>
        /// Instance du gesitonnaire
        /// </summary>
        private static PlayerHandler _instance = null;
        
        /// <summary>
        /// Liste des joueurs
        /// </summary>
        public List<Player> ListOfPlayer { get; private set; }

        /// <summary>
        /// Création du gesitonaire de joueurs
        /// </summary>
        private PlayerHandler()
        {
            ListOfPlayer = new List<Player>();
        }

        /// <summary>
        /// Récupère l'unique instance de la classe : HandlerPlayer
        /// </summary>
        public static PlayerHandler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PlayerHandler();
                }
                return _instance;
            }
        }

        /// <summary>
        /// Ajoute un joueur à la liste des joueur
        /// </summary>
        /// <param name="pPlayer"></param>
        public void AddPlayer(Player pPlayer)
        {
            ListOfPlayer.Add(pPlayer);
        }

        /// <summary>
        /// Récupère le joueur courant
        /// </summary>
        /// <returns></returns>
        public Player GetCurrentPlayer()
        {
            Predicate<Player> findPlayer = (Player p) => { return p.Status == Player.PLAYING; };
            return ListOfPlayer.Find(findPlayer);
        }
    }
}
