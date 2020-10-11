using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate
{
    class CalculateString
    {
        String num1;
        String num2;
        Int64 num11;
        Int64 num22;
        #region 属性
        public String Num1
        {
            get { return num1; }
            set { num1 = value; }
        }
        public String Num2
        {
            get { return num2; }
            set { num2 = value; }
        }
        public Int64 Num11
        {
            get { return num11; }
            set { num11 = value; }
        }
        public Int64 Num22
        {
            get { return num22; }
            set { num22 = value; }
        }
        #endregion
        public void input()
        {
            Console.WriteLine("若您输入的是是字符串，请输入T,数字输入F");
            string isnum = Console.ReadLine();
            if (isnum == "T")
            {
                Console.WriteLine("请输入第一个字符串：");
                Num1 = Console.ReadLine();
                Console.WriteLine("请输入第二个字符串：");
                Num2 = Console.ReadLine();
                Console.WriteLine("请输入\"+\",\"-\"任意1种运算符");
                string ss = Console.ReadLine();
                Equals(Num1,Num2);
                switch (ss)
                {
                    case "+":
                        add(Num1, Num2);
                        break;
                    case "-":
                        reduce(Num1, Num2);
                        break;
                    default:
                        Console.WriteLine("您输入的运算符有误！！");
                        break;

                }
            }
            else if (isnum == "F")
            {
                Console.WriteLine("请输入第一个字符串：");
                Num1 = Console.ReadLine();
                Console.WriteLine("请输入第二个字符串：");
                Num2 = Console.ReadLine();
                Console.WriteLine("请输入\"+\",\"-\",\"*\",\"/\",\"%\",\"&\"任意1种运算符");
                string ss = Console.ReadLine();
                Num11 = Convert.ToInt16(Num1);
                Num22 = Convert.ToInt16(Num2);
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
                    case "%":
                        mod();
                        break;
                    case "&":
                        with();
                        break;
                    default:
                        Console.WriteLine("您输入的运算符有误！！");
                        break;

                }
            }
            else
            {
                Console.WriteLine("您输入的运算符有误！！");
            }
            
        }



        public void add(String s1,String s2)
        {
            String db2 = s1 + s2;
            Console.WriteLine("进行加法运算的结果为" + db2);
        }
        public void reduce(String s1,String s2)
        {
            bool isexist = s1.Contains(s2);
            string s3;
            if (isexist)
            {
                    int i = s1.IndexOf(s2);
                    s3 = s1.Remove(i, s2.Length);
                    reduce(s3,s2);
                    if (!s3.Contains(s2))
                    {
                        Console.WriteLine("进行减法运算的结果" + s3.ToString());
                    }

            }
            else
            {

                Console.WriteLine("无法进行减法运算");
            }
        }
        public void Equals(String s1,String s2)
        {
            if (s1.CompareTo(s2)==0)
            {
                Console.WriteLine("输入的两个字符串相等");
            }
            else
            {
                Console.WriteLine("输入的两个字符串不相等");
            }
        }


        public void add()
        {
            Int64 db2 = Num11 + Num22;
            Console.WriteLine("进行加法运算的结果为" + db2);
        }
        public void reduce()
        {
            Int64 db3 = Num11 - Num22;
            Console.WriteLine("进行减法运算的结果" + db3);
        }
        public void multiply()
        {
            Int64 db4 = Num11 * Num22;
            Console.WriteLine("进行乘法运算的结果为" + db4);
        }
        public void devise()
        {
            double db5 = (double)Num11 / Num22;
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
        //增加对两个数的取余运算和按位与运算
        public void mod()
        {
            Int64 db6 = Num11 % Num22;
            Console.WriteLine("进行取余运算的结果为" + db6);
        }
        public void with()
        {
            Int64 db7 = Num11 & Num22;
            Console.WriteLine("进行加法运算的结果为" + db7);
        }
    }
}
