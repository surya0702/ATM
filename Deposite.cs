using System;
using System.Collections.Generic;

namespace Depositer
{
    class DepositeAmount
    {
        public void Deposit(List<BankDetails> Details,int Amount,int UserPin,int account) // Depositing Amount into the Account.
        {
            foreach(BankDetails i in Details)
            {
                if(i.PIN==UserPin){ // Checking if the userPin is available in the BankDetails dictionary or not.
                    i.AmountAvailable+=Amount; // Updating the available amount in the account.
                    break;
                }
            }
            Console.WriteLine("\n -------------------------------------------");
            Console.WriteLine("| "+ Amount +" has been Debitted in your Account |".ToUpper());
            Console.WriteLine(" -------------------------------------------\n");
            Log.TransactionLog log=new Log.TransactionLog();
            string description="Deposited from "+account;
            log.Adder(description,Amount); // Adding the Deposit
        }
    }
}