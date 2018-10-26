using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Model.Component
{
    /// <summary>
    /// Jeux Monopoly
    /// </summary>
    public class Game
    {
        public static Game _instance = null;
        private int Round {get;set;}       
        

       
        /// <summary>
        /// Crée l'instance du jeux Monopoly
        /// </summary>
        private Game()
        {
            Round = 0;
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

        
        
    }
}
