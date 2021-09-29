using System;
using System.Collections.Generic;

namespace Account
{
    class AccountCreator
    {
        public void Creator(List<BankDetails> l)
        {
            string name;
            int pin,amount=0;
            Console.WriteLine("Enter your Name : ");
            name=Console.ReadLine();
            Console.WriteLine("Enter a PIN number for your account : ");
            pin=int.Parse(Console.ReadLine());
            l.Add(new BankDetails(){Name=name, PIN=pin, AmountAvailable=amount});
            AvailableOptions.Options options=new AvailableOptions.Options();
            options.OptionsPrinter(l,pin);
        }
    }
}