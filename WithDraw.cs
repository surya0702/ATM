using System;
using System.Collections.Generic;

namespace WithDrawer
{
    class WithDrawAmount
    {
        public void WithDraw(List<BankDetails> Details,int Amount,int UserPin,int account) // To Withdraw the Amount.
        {
            foreach(BankDetails i in Details) // Traversing the Bank Details Dictionary.
            {
                if(i.PIN==UserPin){ // Checking if the userPin is available or not in the BankDetails Dictionary
                    if(i.AmountAvailable<Amount) // If the available amount is less the withdraw amount.
                    {
                        Console.WriteLine("\nInsufficient Balance!".ToUpper());
                    }
                    else 
                    {
                        i.AmountAvailable-=Amount;
                        Log.TransactionLog log=new Log.TransactionLog();
                        string description="WithDraw from "+account;
                        log.Adder(description,Amount); // Adding the withdrawl into Transaction Log.
                        Console.WriteLine("\n --------------------------------------------");
                        Console.WriteLine("| "+Amount+" has been WithDrawn from your Account".ToUpper()+" |");
                        Console.WriteLine(" --------------------------------------------\n");
                    }
                    break;
                }
            }
            
        }
    }
}