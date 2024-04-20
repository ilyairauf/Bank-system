using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace main
{
    public class BankAccount()
    {
        // account number yerine password elave ettim  
        
        private dynamic password;
        private int accountHolderID = 0;
        private int balance = 0;
        // isActive fieldinin ve propertysinin bir funksiyasi yoxdu eger istesek yeni menuya block account elave edib activeliyini dayandirmaq olar dhaa maraqli olardi ama complexlesdirmirem
        private bool isActive;
        private string openedDate;
        //private string openedDate = today.ToString("dd/MM/yyyy");
        
   

        public int AccountHolderID { get; set; }
        public int Balance { get; set; }
        public bool IsActive { get; set; }
        public string OpenDate { get; set; }
        public dynamic Password { get; set; }
        public string AccountName { get; set; }

        public int Deposit(int money,int balance)
        {
            balance += money;
            Console.WriteLine("Your Balance " + balance);
            return balance;
        }
        public int Withdraw(int money,int Balance) {
            if (Balance >= money)
            {
                Balance -= money;
                Console.WriteLine($"Your money ${money}");
                Console.WriteLine("Your Balance " + Balance);
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
            }
            return Balance;
        }

    } 
}
