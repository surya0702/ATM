using System;
using System.Collections.Generic;
using Bank;

class Program
    {
    public static List<BankDetails> l=new List<BankDetails>(); // List of BankDetails of Users.
    public static List<int> pins=new List<int>(){1234,5678}; // List of PINs available in the BankDetails.
    public static List<int> Accounts=new List<int>(){12345678,23456789};

    static void Main(string[] args)
    {
        bool flag=true;
        // Default Bank Details
        l.Add(new BankDetails(){AccountNo=12345678, PIN=1234, AmountAvailable=10000}); 
        l.Add(new BankDetails(){AccountNo=23456789, PIN=5678, AmountAvailable=8000});
        string[] loginOptions={"Login", "New Customer", "Exit"}; // Login Options available
        while(flag) // Iterating untill the user wants to exit the application.
        {
            Console.WriteLine("\nHello Welcome to XYZ ATM!");
            for(int i=0;i<loginOptions.Length;i++){ // Displaying the Login Options.
                Console.WriteLine("("+(i+1)+") "+loginOptions[i]);
            }
            Console.WriteLine("\nEnter the number corresponding to your Choise");
            int userInput=int.Parse(Console.ReadLine());
            if(userInput==1){
                Logger log=new Logger();
                log.Login(l,Accounts,pins); // Loging in the User.
            }
            else if(userInput==2){ // Creating a new Account for the user.
                AccountCreator account=new AccountCreator();
                account.Creator(l,pins,Accounts);
            }
            else if(userInput==3){ // Displaying the Bank Details and exiting from the user.
                Console.WriteLine("\nBank Details :");
                foreach(BankDetails i in l){
                    Console.WriteLine(i);
                }
                flag=false;
            }
            else{ // For any invalid input.
                Console.WriteLine("\nEnter a Valid Input".ToUpper());
            }
        }
    }
}
