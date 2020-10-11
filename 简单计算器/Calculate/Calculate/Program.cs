using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//按以下要求实现一个简单的计算器，可以进行两个整数的加减乘除运算。要求从键盘输入两个数和要进行的操作，输出运算结果。
//1、代码中对出现的异常进行捕获并给用户以必要的提示。
//2、通过定义类的思想来实现计算器的功能。
//3、编写一个方法，对你所定义的类中系统固有的Equals方法进行重载，可以实现两个整数是否相等的判断。
namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateString cas = new CalculateString();
            cas.input();
        }
    }
}
