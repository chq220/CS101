using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS101
{
    public static class CSBasic
    {
        public static void HelloCSharp()
        {
            Console.WriteLine("Hello C#");
            Console.WriteLine(Console.BackgroundColor);
            Console.WriteLine(Console.BufferHeight);
            Console.WriteLine(Console.BufferWidth);
            Console.WriteLine(Console.CapsLock);
            Console.WriteLine(Console.CursorLeft);
            Console.WriteLine("CursorSize: " + Console.CursorSize.ToString());
            return;
        }

        public static void CalcCircle()
        {
            const decimal pi = 3.1415926M;
            //圆的半径
            decimal radius = 3.0M;
            //圆的周长
            decimal c = radius * pi * 2;
            //圆的面积
            decimal s = pi * radius * radius;
            //输出圆的周长
            Console.WriteLine("圆的周长： " + c.ToString());
            //输出圆的面积
            Console.WriteLine("圆的面积: " + s.ToString());
            return;
        }
        public static void ConsoleArithmeticOperatiors()
        {
            double num1 = 0;
            double num2 = 0;
            Console.WriteLine("请输入两个数字");

            Console.WriteLine("第一个数字为： ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("第二个数字为： ");
            num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;
            Console.WriteLine($"第一个数字与第二个数字之和为{sum}");
            return;
        }

        public static void ConsoleCharClass()
        {
            char a = 'a';
            char M = 'M';
            char six = '6';
            char dot = '.';
            char star = '☆';
            char space = ' ';
            char seprator = ' ';
                
            Console.WriteLine("IsLetter方法判断a是否为字母:{0}", Char.IsLetter(a));
            Console.WriteLine("IsLetterOrDigit方法判断M是否为字母或者数字{0}", Char.IsLetterOrDigit(M));
            Console.WriteLine("IsDigit方法判断six是否为十进制数字{0}", Char.IsDigit(six));
            Console.WriteLine("IsLower方法判断a是否为小写字母{0}", Char.IsLower(a));
            Console.WriteLine("IsUpper方法判断M是否为大写字母{0}", Char.IsUpper(M));
            Console.WriteLine("IsPunctuation方法判断变量dot是否为标点符号{0}", Char.IsPunctuation(dot));
            Console.WriteLine("IsSymbol方法判断star是否为符号{0}", Char.IsSymbol(star));
            Console.WriteLine("IsWhiteSpace方法判断space是否为空格符{0}", Char.IsWhiteSpace(space));
            Console.WriteLine("IsSeparator方法判断变量seprator是否为分割符{0}", Char.IsSeparator(seprator));
            return;
        }

        public static void ConsoleStringEquals()
        {
            string str1 = "Hello World!";
            string str2 = "HelloWorld!";
            Console.WriteLine("str1和str2是否相同：{0}", str1.Equals(str2));
            return;
        }

        public delegate void SayDelegate(string name);

        public static void ConsoleDelegate()
        {
            DelegateClass dc = new DelegateClass();
            SayDelegate sayDelegate1 = new SayDelegate(dc.ChineseSay);
            SayDelegate sayDelegate2 = dc.EnglishSay;
            SayDelegate sayDelegate3 = dc.JapaneseSay;
            dc.Say("李菁", sayDelegate1);
            dc.Say("Guo Degang", sayDelegate2);
            dc.Say("ゆけ", sayDelegate3);
            return;
        }

        public class DelegateClass
        {
            public void ChineseSay(string name)
            {
                Console.WriteLine("你好,{0}", name);
                Console.WriteLine();
            }

            public void EnglishSay(string name)
            {
                Console.WriteLine("Hello,{0}", name);
                Console.WriteLine();
            }

            public void JapaneseSay(string name)
            {
                Console.WriteLine($"こんにちは,{name}");
                Console.WriteLine();
            }

            public void Say(string name, SayDelegate sayDelegate)
            {
                sayDelegate(name);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CSBasic.HelloCSharp();
            CSBasic.CalcCircle();
            //CSBasic.ConsoleArithmeticOperatiors();
            CSBasic.ConsoleCharClass();
            CSBasic.ConsoleStringEquals();
            CSBasic.ConsoleDelegate();
        
            Console.ReadLine();
        }
    }
}
