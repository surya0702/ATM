using System;
using System.Collections.Generic;

namespace Chooser
{   
    public class Choose
    {
        public void ChooseOptions(string option,List<BankDetails> l,int pin){
            bool flag=true;
            if(option=="1"){
                Console.WriteLine("Enter the Amount you want to Deposite ");
                int amount=int.Parse(Console.ReadLine());
                Depositer.DepositeAmount deposite=new Depositer.DepositeAmount();
                deposite.Deposite(l,amount,pin);
            }
            else if(option=="2"){
                Console.WriteLine("Enter the Amount you want to WithDraw ");
                int amount=int.Parse(Console.ReadLine());
                WithDrawer.WithDrawAmount withDraw=new WithDrawer.WithDrawAmount();
                withDraw.WithDraw(l,amount,pin);
            }
            else if(option=="3"){
                Console.WriteLine("Enter the Name of the user to which you would like to transfer the amount");
                string transfererName=Console.ReadLine();
                Console.WriteLine("Enter the Amount you would like to Transfer");
                int amount=int.Parse(Console.ReadLine());
                Transferer.TransferAmount transfer=new Transferer.TransferAmount();
                transfer.Transfer(l,pin,transfererName,amount);
            }
            else if(option=="4"){
                Log.TransactionLog log=new Log.TransactionLog();
                log.LogPrinter();
            }
            else if(option=="5"){
                flag=false;
            }
            if(flag){
                AvailableOptions.Options options=new AvailableOptions.Options();
                options.OptionsPrinter(l,pin);
            }
        }
    }
}