using System;

namespace Encapsulation.Banking
{
    public class BankAccount
    {
        private string _accountNumber;
        private string _accountHolder;
        private double _balance;

    #pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public BankAccount(string accountNumber, string accountHolder, double balance)
    #pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        {
            AccountNumber = !string.IsNullOrEmpty(accountNumber) ? accountNumber : "Unknown";
            AccountHolder = !string.IsNullOrEmpty(accountHolder) ? accountHolder : "Unknown";

            Balance = balance >= 0 ? balance : 0.0;
        }

        public string AccountNumber
        {
            get { return _accountNumber; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _accountNumber = value;
                }
            }
        }

        public string AccountHolder
        {
            get { return _accountHolder; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _accountHolder = value;
                }
            }
        }

        public double Balance
        {
            get { return _balance; }
            private set
            {
                if (value >= 0)
                {
                    _balance = value;
                }
            }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"Deposit sebesar {amount:C} berhasil.");
            }
            else
            {
                Console.WriteLine("Jumlah deposit tidak boleh negatif.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && _balance >= amount)
            {
                _balance -= amount;
                Console.WriteLine($"Penarikan sebesar {amount:C} berhasil.");
            }
            else if (amount <= 0)
            {
                Console.WriteLine("Jumlah penarikan tidak boleh negatif.");
            }
            else
            {
                Console.WriteLine("Saldo tidak mencukupi untuk melakukan penarikan.");
            }
        }

        public double GetBalance()
        {
            return _balance;
        }
    }
}