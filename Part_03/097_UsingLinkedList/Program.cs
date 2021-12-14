using _096_LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _097_UsingLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Random r = new Random();

            for (int i = 0; i < 5; i++)
            {
                list.InsertLast(r.Next(100));
            }

            Console.WriteLine("랜덤한 5개 값의 리스트입니다");
            list.Print();

            Console.Write("\n맨 앞에 10, 맨 뒤에 90 삽입. <Enter> 입력하세요.");
            Console.ReadLine();
            list.InsertFront(10);
            list.InsertLast(90);
            list.Print();
        }
    }
}
