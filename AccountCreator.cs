using System;
using System.Collections.Generic;

namespace Account
{
    class AccountCreator
    {
        public void Creator(List<BankDetails> l,List<int> pins)
        {
            int account, pin,amount=1000; // Default values of the new Accout created for the user.
            Console.WriteLine("Enter your Account Number : ");
            account=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a 4-Digit PIN number for your account : ");
            while(true){ // Iterating untill the user enter a Unique PIN which is not present already in BankDetails.
                pin=int.Parse(Console.ReadLine());
                if(pins.Contains(pin)){ // Checking if the userpin is already present in the pins list.
                    Console.WriteLine("PIN is unavilable! Please enter another PIN");
                }
                else{
                    break;
                }
            }
            l.Add(new BankDetails(){AccountNo=account, PIN=pin, AmountAvailable=amount});
            pins.Add(pin); // Adding the newly created account pin to pins list.
            Console.WriteLine("\nYour Account has been Created!".ToUpper());
            AvailableOptions.Options options=new AvailableOptions.Options(); 
            options.OptionsPrinter(l,pin,account); // Calling the Options class.
        }
    }
}