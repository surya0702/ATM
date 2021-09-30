using System;
using System.Collections.Generic;

namespace Log
{   
    public class TransactionLog
    {
        public static Dictionary<string,int> log=new Dictionary<string, int>();

        public void Adder(string description,int amount){ // Adds a new Transaction into the Log Dictionary.
            log.Add(description,amount);
        }
        public void LogPrinter() // Prints the Log Dictionary
        {
            Console.WriteLine("\n -------------------");
            Console.WriteLine("| Transaction Log   |".ToUpper());
            Console.WriteLine(" -------------------\n");
            foreach(KeyValuePair<string,int> i in log){
                Console.WriteLine(i.Value+"\t"+i.Key);
            }
        }
    }
}