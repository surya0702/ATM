using System;
using System.Collections.Generic;

class Program
    {
    public static List<BankDetails> l=new List<BankDetails>(); // List of BankDetails of Users.
    public static List<int> pins=new List<int>(){1234,5678}; // List of PINs available in the BankDetails.
    public static List<int> Accounts=new List<int>(){12345678,23456789};
    static void Login(){
        Console.WriteLine("Enter your Account Number");
        int userAccount=int.Parse(Console.ReadLine());
        if(Accounts.Contains(userAccount))//If PIN is present in pins List then display the options tab.
        {
            Console.WriteLine("Enter your 4-Digit PIN");
            int userPin=int.Parse(Console.ReadLine());
            if(pins.Contains(userPin)){
                AvailableOptions.Options options=new AvailableOptions.Options();
                options.OptionsPrinter(l,userPin,userAccount);
            }
            else{
                Console.WriteLine("\nPlease enter a valid PIN".ToUpper());
            }
        }
        else // If PIN was not present in the pins List.
        {
            Console.WriteLine("\nPlease enter a valid Account Number".ToUpper());
        }
    }

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
                Login(); // Loging in the User.
            }
            else if(userInput==2){ // Creating a new Account for the user.
                Account.AccountCreator account=new Account.AccountCreator();
                account.Creator(l,pins);
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
