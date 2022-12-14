using System;
using System.Collections.Generic;

namespace HackerRank30DaysOfCodeD18
{
    class Program
    {
        //Write your code here -- Kodlarını buraya yazabilirsin.
        Stack<char> s = new Stack<char>();
        Queue<char> q = new Queue<char>();

        void pushCharacter(char ch)
        {
            s.Push(ch);
        }
        void enqueueCharacter(char ch)
        {
            q.Enqueue(ch);
        }
        char popCharacter()
        {
            return s.Pop();
        }
        char dequeueCharacter()
        {
            return q.Dequeue();
        }
        static void Main(string[] args)
        {
            // read the string s.  -- s stringini oku.
            string s = Console.ReadLine();

            // create the Solution class object p. -- Sınıftan nesne üret
            Program obj = new Program();

            // push/enqueue all the characters of string s to stack. -- String karakterlerin s değerini yığına ve kuyruğa pushluyoruz. 
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack. -- Yığının en üstteki elemanını siliyoruz.
            // dequeue the first character from queue. -- Kuyrğun ilk elemanını kuyruktan çıkarıyoruz.
            // compare both the characters. -- Her 2 karakteride karşılaştırıyoruz.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not. -- Son olarak stringin palindrome olup olmadığını yazdırın.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }
    }
}
