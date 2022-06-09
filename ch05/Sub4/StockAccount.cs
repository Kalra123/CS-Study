using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch05.Sub4
{
    internal class StockAccount : Account
    {
        protected string stock;
        protected int amount;
        protected int price;
        

    }
    public StockAccount(string bank, string id, string name, int balance, string stock, int amount, int price);
    {
        this.stock = Stock;
        this.amount = amount;
        this.price = price;
    }

    public void Sell (int amount, int price)
    {
        this.amount -= amount;
        base.balance += amount * price;

    }

    public void Buy (int amount, int price)
    {
        this.amount += amount;
        base.balance += money;

    }

    public void Show()
    {
        Console.WriteLine("주식종목 : " + Stock);
        Console.WriteLine("주식수량 : " + amount);
        Console.WriteLine("주식가격 : " + price);
        Console.WriteLine("----------------------");
    }


}
