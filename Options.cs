using System;
using System.Collections.Generic;

namespace AvailableOptions
{   
    public class Options
    {
        public void OptionsPrinter(List<BankDetails> l,int userPin){
            string[] options={"Deposite Amount","Withdraw Amount","Transfer Amount","Print Transaction History","Exit"};
            for(int i=0;i<options.Length;i++)
            {
                Console.WriteLine("("+(i+1)+") "+options[i]);
            }
            Console.WriteLine("Please select an option");
            string userOption=Console.ReadLine();
            Chooser.Choose choice=new Chooser.Choose();
            choice.ChooseOptions(userOption,l,userPin);
        }
    }
}