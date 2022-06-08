﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch05.sub1
{
    internal class Account
    {
        // 속성
        public string Bank;
        public string Id;
        public string Name;
        public int Balance;

        // 기능
        public void Deposit(int money) 
        {
            this.Balance += money;
        
        }
        public void Withdraw(int money) 
        {
            this.Balance -= money;

        
        }
        public void Show() 
        {
            Console.WriteLine("===================");
            Console.WriteLine("은행명 : "+Bank);
            Console.WriteLine("계좌번호 : "+Id);
            Console.WriteLine("입금주 : "+Name);
            Console.WriteLine("현재잔액 : "+Balance);

                
        
        }

    }
}
