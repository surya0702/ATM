using System;
using System.Collections.Generic; 
//using static BankDetails;
// using AvailableOptions;
// using Account;

class Program
    {
        public static List<BankDetails> l=new List<BankDetails>();
    static void Main(string[] args)
    {
        List<int> pins=new List<int>(){1234,5678};
        l.Add(new BankDetails(){Name="Bob", PIN=1234, AmountAvailable=10000});
        l.Add(new BankDetails(){Name="John", PIN=5678, AmountAvailable=8000});
        Console.WriteLine("Hello Welcome to XYZ ATM!");
        Console.WriteLine("Enter you PIN");
        int userPin=int.Parse(Console.ReadLine());
        if(pins.Contains(userPin))
        {
            AvailableOptions.Options options=new AvailableOptions.Options();
            options.OptionsPrinter(l,userPin);
        }
        else
        {
            Console.WriteLine("Would you like to create a new Account? : Yes/No");
            string newAccount=Console.ReadLine();
            List<string> PossibleAnswers=new List<string>(){"yes","y"};
            if(PossibleAnswers.Contains(newAccount.ToLower())){
                Account.AccountCreator account=new Account.AccountCreator();
                account.Creator(l);
            }
        }
        foreach(BankDetails i in l){
            Console.WriteLine(i);
        }
    }
}
