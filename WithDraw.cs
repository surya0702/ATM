using System;
using System.Collections.Generic;

namespace WithDrawer
{
    class WithDrawAmount
    {
        public void WithDraw(List<BankDetails> Details,int Amount,int UserPin)
        {
            foreach(BankDetails i in Details)
            {
                if(i.PIN==UserPin){
                    if(i.AmountAvailable<Amount)
                    {
                        Console.WriteLine("Insufficient Balance!");
                    }
                    else
                    {
                        i.AmountAvailable-=Amount;
                        Log.TransactionLog log=new Log.TransactionLog();
                        string description="WithDraw";
                        log.Adder(description,Amount);
                        Console.WriteLine("Amount has been WithDrawn from your Account");
                    }
                    break;
                }
            }
            
        }
    }
}