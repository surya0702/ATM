using System;
using System.Collections.Generic;

namespace Bank
{
    public class Logger
    {
        public void Login(List<BankDetails> l,List<int> Accounts,List<int> pins){
            Console.WriteLine("Enter your Account Number");
            int userAccount=int.Parse(Console.ReadLine());
            if(Accounts.Contains(userAccount))//If userAccount is present in Accounts List then display the options tab.
            {
                Console.WriteLine("Enter your 4-Digit PIN");
                int userPin=int.Parse(Console.ReadLine());
                if(pins.Contains(userPin)){
                    Options options=new Options();
                    options.OptionsPrinter(l,userPin,userAccount);
                }
                else{
                    Console.WriteLine("\nPlease enter a valid PIN".ToUpper());
                }   
            }
            else // If userAccount was not present in the Accounts List.
            {
                Console.WriteLine("\nPlease enter a valid Account Number".ToUpper());
                
            }
    }
    }
}