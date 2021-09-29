using System;
using System.Collections.Generic;

namespace Depositer
{
    class DepositeAmount
    {
        public void Deposite(List<BankDetails> Details,int Amount,int UserPin)
        {
            foreach(BankDetails i in Details)
            {
                if(i.PIN==UserPin){
                    i.AmountAvailable+=Amount;
                    break;
                }
            }
            Console.WriteLine("Amount has been Debitted in your Account");
            Log.TransactionLog log=new Log.TransactionLog();
            string description="Deposite";
            log.Adder(description,Amount);
        }
    }
}