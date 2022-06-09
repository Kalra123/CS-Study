using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch05.Sub2
{
    internal class Account
    {
        // 속성 - 무조건 private 캡슐화 적용
        private string Bank;
        private string Id;
        private string Name;
        private int Balance;

        //  생성자 - 캡슐화된 속성을 초기화 시키기 위한 메서드
        public Account(string Bank, string Id, string Name, int Balance)
        {
            this.Bank = Bank;
            this.Id = Id;
            this.Name = Name;
            this.Balance = Balance;

        }

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
