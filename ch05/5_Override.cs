using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 2022/06/09
 * 이름 조진호
 * 내용 오버라이드 실습하기 교재 p361
 * 
 *오버라이드 (Overrride)
 *- 부모클래스의 메서드를 지식클래스에서 다시 재정의(덮어쓰기)하는 것
 *- 오버라이드를 통해 다형성*****을 실현한다.
 */
namespace ch05
{
    class AAA 
    {
        public void Method1()
        {
            Console.WriteLine("AAA::Method1 ...");
        }

        public virtual void Method2()
        {
            Console.WriteLine("AAA::Method2 ...");
        }

        public virtual void Method3()
        {
            Console.WriteLine("AAA::Method3 ...");
        }
    }
    class BBB : AAA 
    {
        // Method Hiding : BBB의 Method1이 aaa의 method1을 숨김
        public void Method1()
        {
            Console.WriteLine("BBB::Method1 ...");
        }
        // method override : bbb의 
        public void Method2()
        {
            Console.WriteLine("BBB::Method2 ...");
        }
        // method overload : bbb의 method1이 bbb의 method2를
        public void Method3()
        {
            Console.WriteLine("BBB::Method3 ...");
        }

    }
    class CCC : BBB 
        // method hiding : CCC의 Method1dl BBB의 Method1을 숨김
        public new void Method1()
        {
            Console.WriteLine("CCC::Method1 ...");
        }
        // method override : ccc의 method1 을 bbb의 method1에 덮어씌움
        

        public override void Method2()
        {
            Console.WriteLine("BBB::Method2 ...");
        }
        
        public void Method3()
        {
            Console.WriteLine("CCC::Method3 ...");
        }
    }


    internal class _5_Override
    {
        static void Main(string[] args)
        {
        AAA a = new AAA();
        BBB b = new BBB();
        CCC c = new CCC();

        a.Method1();
        a.Method2();
        a.Method3();
        Console.WriteLine();

        b.Method1();
        b.Method2();
        b.Method3();
        Console.WriteLine();

        c.Method1();
        c.Method2();
        c.Method3();
        Console.WriteLine();

        }
    }
}
