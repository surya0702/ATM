using System;
using System.Collections.Generic;

namespace Log
{   
    public class TransactionLog
    {
        public static Dictionary<string,int> log=new Dictionary<string, int>();

        public void Adder(string description,int amount){
            log.Add(description,amount);
        }
        public void LogPrinter()
        {
            foreach(KeyValuePair<string,int> i in log){
                Console.WriteLine(i.Key+" "+i.Value);
            }
        }
    }
}