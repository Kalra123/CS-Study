using ch05.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 2022/06/08
 * 이름 조진호
 * 내용 캡슐화 실습하기 교재 p203
 * 
 * 캡슐화 (Encapsulaton)
 * - 캔슬화는 객체의 내용 (필드)를 외부에서 참조하지 못하도록 객체의 정보를 은닉하는 특성을 말한다.
 * - 캡슐화를 위한 접근 제한자 private. public. protected 를 제공한다.
 * - 은닉된 정보의 안전한 제공을 위해 Getter와 Setter를 제공한다. (프로퍼티)ㄴ
 */
namespace ch05
{
    internal class _2_Encaps
    {
        static void Main5(string[] args)
        {
            // 객체 생성과 초기화(생성자 호출)
            Account kb = new Account("국민은행", "110-12-1234", "김유신", 1000);
            
            kb.Deposit(4000);
            kb.Withdraw(3000);

            // 캡슐화로 취약코드 예방
            //kb.Balance--;
            //kb.Balance += 10;
            
            kb.Show();
        }
    }
}
