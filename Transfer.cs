using System;
using System.Collections.Generic;

namespace Bank
{
    public class TransferAmount
    {
        public void Transfer(List<BankDetails> Details,int pin,int account,int transfererAccountNo,int amount)
        {
            int availableAmount=0;
            foreach(BankDetails i in Details){ // Checking if the available amount is greaterthan or equals to transfer amount.
                if(i.AccountNo==account && i.AmountAvailable>amount){
                    availableAmount=i.AmountAvailable;
                    i.AmountAvailable-=amount;// Available amount after transfer.
                }
            }
            if(availableAmount<amount){ // If the transfer amount is greater then the available amount.
                Console.WriteLine("\nInsufficient Amount to Transfer!".ToUpper());
                return;
            }
            bool flag=true;
            foreach(BankDetails i in Details){ // Traversing the Bank Details Dictionary.
                if(i.AccountNo==transfererAccountNo){ // Checking if the transferer name is available.
                    i.AmountAvailable+=amount;
                    TransactionLog log=new TransactionLog();
                    string description="Transfered from "+account+" to "+transfererAccountNo;
                    log.Adder(description,amount); // Adding the Transfer into Transaction Log.
                    flag=false;
                    Console.WriteLine("\n -----------------------------------");
                    Console.WriteLine("| "+amount+ " has been transfered to ".ToUpper()+transfererAccountNo+" |");
                    Console.WriteLine(" -----------------------------------\n");
                    break;
                }
            }
            if(flag){ // If the transferer name is not available.
                Console.WriteLine("\nEnter a valid Trasfer Account Name".ToUpper());
            }
        }
    }
} 