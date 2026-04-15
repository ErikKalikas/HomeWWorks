using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Works
{
    /*
        Задание 2

        Создать класс BankAccount.

        Поля:
        OwnerName (строка) — имя владельца
        Balance (double) — текущий баланс

        Методы:
        Deposit(double amount) — пополнение счёта
        Withdraw(double amount) — снятие денег
        GetBalance() — возвращает текущий баланс

        Условия:
        Нельзя снять больше денег, чем есть на счёте
        Если средств недостаточно — вывести сообщение
     */
    public class BankAccount
    {
        public string OwnerName { get; }
        public double Balance { get; set; }

        public BankAccount(string OwnerName, double Balance)
        {
            this.OwnerName = OwnerName;
            this.Balance = Balance;
        }

        public double Deposit(double howmuch)
        {
            Balance += howmuch;
            Console.WriteLine(OwnerName + " Balance: " + Balance);
            return Balance;
        }

        public double Withdraw(double howmuch)
        {
            Balance -= howmuch;
            Console.WriteLine(OwnerName + " Balance: " + Balance);
            return Balance;
        }

        public void GetBalance()
        {
            Console.WriteLine(OwnerName + " Balance: " + Balance);
        }
    }
}
