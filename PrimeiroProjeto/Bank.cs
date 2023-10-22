using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Bank
    {
        private double _balance;
        private readonly double _withdrawalFee = 5.00;
        public int BankNumber { get; private set; }
        public string BankPersonName { get; set; }
        public double InitialDepository { get; private set; }

        public Bank()
        {

        }

        public Bank(int bankNumber, string bankPersonName, double initialDepository)
        {
            this.BankNumber = bankNumber;
            this.BankPersonName = bankPersonName;
            AddBalance(initialDepository);
        }

        public Bank(int bankNumber, string bankPersonName)
        {
            this.BankNumber = bankNumber;
            this.BankPersonName = bankPersonName;
        }

        public void AddBalance(double valueDepositiry)
        {
            this._balance += valueDepositiry;
        }

        public void RemoveBalance(double valueRemove)
        {
            this._balance -= (valueRemove + this._withdrawalFee);
        }

        public override string ToString()
        {
            return $"Conta: {this.BankNumber}, " +
                $"Titular: {this.BankPersonName}, " +
                $"Saldo: $ {this._balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
