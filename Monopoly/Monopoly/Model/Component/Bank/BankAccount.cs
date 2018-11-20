using Monopoly.Model.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Model.Component.Bank
{
    public class BankAccount
    {
        #region Variables
        /// <summary>
        /// Montant du compte en banque
        /// </summary>
        private int _amount { get; set; }
#endregion
        #region Constructeurs
        /// <summary>
        /// Crée une instance de la classe
        /// </summary>
        public BankAccount()
        {
            this._amount = 0;
        }

        /// <summary>
        /// Crée d'une instance de la classe
        /// </summary>
        /// <param name="amount">Montant du compte</param>
        public BankAccount( int amount)
        {
            this._amount = amount;
        }
        #endregion
        #region Methodes privé
        /// <summary>
        /// Ajoute un montant au solde bancaire
        /// </summary>
        /// <param name="amount"></param>
        private void AddAmount(int amount)
        {
            this._amount += amount;
        }

        /// <summary>
        /// Enlève un montant au solde bancaire
        /// </summary>
        /// <param name="amount"></param>
        private void RemoveAmount(int amount)
        {
            this._amount -= amount;
        }

        /// <summary>
        /// Vérifie si le solde bancaire est suffisant
        /// </summary>
        /// <param name="amount">Montant</param>
        /// <returns></returns>
        private bool CheckIfBankBalanceIsEnougth(int amount)
        {
            if ((this._amount - amount) > 0)
            {
                return true;
            }
            else
            {
                throw new BankBalanceIsNotEnougth();
            }
        }

        /// <summary>
        /// Retire un montant du solde bancaire
        /// </summary>
        /// <param name="amount">Montant</param>
        private int Withdraw(int amount)
        {
            if (CheckIfBankBalanceIsEnougth(amount))
            {
                RemoveAmount(amount);
                return amount;
            }
            return 0;
        }
        #endregion
        #region Methodes publique
        /// <summary>
        /// Retourne le sold du compte bancaire
        /// </summary>
        /// <returns></returns>
        public int GetAmount() { return this._amount; }


        /// <summary>
        /// Effectue un virement sur le compte cible
        /// </summary>
        /// <param name="bankAccount">Compte bancaire cible</param>
        /// <param name="amount">Montant</param>
        public void BankTransfer(BankAccount bankAccount, int amount)
        {
            int money = this.Withdraw(amount);
            bankAccount.AddAmount(money);

        }

        #endregion

    }
}
