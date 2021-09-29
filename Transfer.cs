using System;
using System.Collections.Generic;
using Log;

namespace Transferer
{
    public class TransferAmount
    {
        public void Transfer(List<BankDetails> Details,int pin,string transfererName,int amount)
        {
            int availableAmount=0;
            foreach(BankDetails i in Details){
                if(i.PIN==pin && i.AmountAvailable>amount){
                    availableAmount=i.AmountAvailable;
                    i.AmountAvailable-=amount;
                }
            }
            if(availableAmount<amount){
                Console.WriteLine("Insufficient Amount to Transfer!");
                return;
            }
            bool flag=true;
            foreach(BankDetails i in Details){
                if(i.Name.ToLower()==transfererName.ToLower()){
                    i.AmountAvailable+=amount;
                    Log.TransactionLog log=new Log.TransactionLog();
                    string description="Transfer to "+transfererName;
                    log.Adder(description,amount);
                    flag=false;
                    break;
                }
            }
            if(flag){
                Console.WriteLine("Enter a valid Trasfer Account Name");
            }
        }
    }
} 