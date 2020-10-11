using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate
{
    class Calculate
    {
        int num1;
        int num2;
        public int Num1
        {
            get { return num1; }
            set { num1 = value; }
        }
        public int Num2
        {
            get { return num2; }
            set { num2 = value; }
        }
        public void input()
        {
            Console.WriteLine("请输入第一个整数：");
            Num1=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("请输入第二个整数：");
            Num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("请输入\"+\",\"-\",\"*\",\"/\"任意1种运算符");
            string ss = Console.ReadLine();
            Equals();
            switch (ss)
            {
                case "+":
                    add();
                    break;
                case "-":
                    reduce();
                    break;
                case "*":
                    multiply();
                    break;
                case "/":
                    devise();
                    break;

                default:
                    Console.WriteLine("您输入的运算符有误！！");
                    break;

            }
        }
        //public void add()
        //{
        //    int db2 = Num1 + Num2;
        //    Console.WriteLine("进行加法运算的结果为" + db2);
        //}
        //public void reduce()
        //{
        //    int db3 = Num1 - Num2;
        //    Console.WriteLine("进行减法运算的结果" + db3);
        //}
        /// <summary>
        /// //////重构
        /// </summary>
        public void add()
        {
            String db2 = Num1.ToString() + Num2.ToString();
            Console.WriteLine("进行加法运算的结果为" + db2);
        }
        public void reduce()
        {
            String s1 = Num1.ToString();
            String s2 = Num2.ToString();
            bool isexist = s1.Contains(s2);
            if (isexist)
            {
                int i=s1.IndexOf(s2);
                string s3=s1.Remove(i,s2.Length);
                Console.WriteLine("进行减法运算的结果" + s3.ToString() + "  " + i + "   " + s2.Length);

            }
            else
            {

                Console.WriteLine("无法进行减法运算" );
            }
        }


        public void multiply()
        {
            int db4 = Num1 * Num2;
            Console.WriteLine("进行乘法运算的结果为" + db4);
        }
        public void devise()
        {
            double db5 =(double) Num1 / Num2;
            Console.WriteLine("进行除法运算的结果" + db5);
        }
        public void Equals()
        {
            if (Num1 == Num2)
            {
                Console.WriteLine("输入的两个数相等");
            }
            else 
            {
                Console.WriteLine("输入的两个数不相等");
            }
        }
    }
}
