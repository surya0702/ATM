using System;
using System.Collections.Generic;

namespace Bank
{   
    public class Choose
    {
        public void ChooseOptions(string option,List<BankDetails> l,int pin,int account){
            bool flag=true;
            // Based on the user option.
            if(option=="1"){ // Depositing
                Console.WriteLine("Enter the Amount you want to Deposit ");
                int amount=int.Parse(Console.ReadLine());
                DepositeAmount deposite=new DepositeAmount();
                deposite.Deposit(l,amount,pin,account); // Calling the Deposite Class
            }
            else if(option=="2"){ // Withdrawing
                Console.WriteLine("Enter the Amount you want to WithDraw ");
                int amount=int.Parse(Console.ReadLine());
                WithDrawAmount withDraw=new WithDrawAmount();
                withDraw.WithDraw(l,amount,pin,account); // Calling the Withdraw class
            }
            else if(option=="3"){ // Transfering
                Console.WriteLine("Enter the Account number to which you would to transfer ");
                int transfererAccountNo=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Amount you would like to Transfer");
                int amount=int.Parse(Console.ReadLine());
                TransferAmount transfer=new TransferAmount();
                transfer.Transfer(l,pin,account,transfererAccountNo,amount); // Calling the Transfer Account.
            }
            else if(option=="4"){ // Transaction Log
                TransactionLog log=new TransactionLog();
                log.LogPrinter();
            }
            else if(option=="5"){ // Exiting
                Console.WriteLine("\nYou have been Logged Out!".ToUpper());
                flag=false;
            }
            if(flag){ // Iterating untill the user prompts to exit the account.
                Options options=new Options();
                options.OptionsPrinter(l,pin,account); // Calling the options class.
            }
        }
    }
}