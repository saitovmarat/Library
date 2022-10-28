using System;
using System.Collections.Generic;
using System.Text;

namespace Тумаков
{
    enum TypeOfBankAccount
    {
        current,
        saving
    }
    class BankAccount
    {
        private int AccountNumber { get; set; }
        private int AmountOfMoney { get; set; }
        private TypeOfBankAccount Type {get; set;}
        public BankAccount(int accountNumber, int amountOfMoney, TypeOfBankAccount type)
        {
            AccountNumber = accountNumber;
            AmountOfMoney = amountOfMoney;
            Type = type;
        }
        public override string ToString()
        {
            return $"{AccountNumber} {AmountOfMoney} {Type}";
        }
        public double AcountNumber()
        {
            
        }
    }
}
