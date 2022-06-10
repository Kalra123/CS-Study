using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    internal class _2_04
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 2, 1, 5, 3 };

            for (int i =0; i<4; i++)
            {
                for (int j = i +1; j < 5; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            // 정렬된 배열 출력하기
            foreach (int n in arr)
            {
                Console.Write(n + " ");
            }
        }
                
    }
}
