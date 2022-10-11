using System.Runtime.InteropServices;
using System.Xml.Schema;

internal class Program
{
    /// <summary>
    /// main的作用，入口函数
    /// </summary>
    /// <param name="args">传入参数</param>
    private static void Main(string[] args)
    {
        //
        //
        //Start 基础语法
        //
        //
        //
        //单行注释
        /*
          1行
          2行
          多行注释
         */
        //输入
        string score = Console.ReadLine();
        //if-else
        if (score == "")
        {
            Console.WriteLine("不得为空！");
        }
        else
        {
            Console.WriteLine(score);
        }
        Console.ReadLine();
        //for
        int total = 2;
        for (int i = 1; i <= 10; i++)
        {
            total += i;
            Thread.Sleep(1);
        }
        Console.WriteLine(total);
        //二维数组读写及其遍历
        string[,] doubleA = new string[2, 3] { { "sleep", "eat", "drink" }, { "i", "he", "she" } };
        for (int k = 0; k < doubleA.GetLength(0); k++)
        {
            for (int j = 0; j < doubleA.GetLength(1); j++)
            {
                //转义符
                Console.WriteLine(doubleA[k, j] + "\t");
            }
            Console.WriteLine();
        }
        //switch-case
        int week=1;
        switch (week)
        {
            case 1:
                Console.WriteLine("周一");
                break;
            default:
                Console.WriteLine("不是周一");
                break;

        }
        //函数及其重载
        string returnValue;
        string returnValue2;
        int iref=10;
        int outint;
        returnValue = Hello("Leo", 100);
        Hello("Eric", "me",ref iref,out returnValue2,out outint);
        int difinal = Hello(100);
        int dfinal = Plusd(100);
        Console.WriteLine("origin:"+returnValue);
        //类型转换
        Convert.ToDouble(outint);
        //占位符
        Console.WriteLine("after:"+returnValue2+iref+"&"+outint+"--a--"+difinal+"&{0}",dfinal);
        //等待退出
        Console.ReadLine();
        //
        //
        //end 基础语法
        //
        //
    }
    /// <summary>
    /// Hello的作用
    /// </summary>
    /// <param name="name">string类型的name</param>
    /// <param name="age">int类型的age</param>
    /// <returns>返回string</returns>
    static string Hello(string name, int age)
    {
        Console.WriteLine(name + age);
        return "returnValue123";
    }
    /// <summary>
    /// Hello重载,ref&out params
    /// </summary>
    /// <param name="obj">另一个string参数</param>
    static void Hello(string name, string obj,ref int iref,out string returnValue,out int outint)
    {
        Console.WriteLine(name + obj);
        iref++;
        Console.WriteLine(iref);
        returnValue="returnValue123";
        outint = 100;
    }
    /// <summary>
    /// 重载for循环实现1+…+N
    /// </summary>
    /// <param name="di">1加到此int</param>
    /// <returns>total</returns>
    static int Hello(int di)
    {
        int tot = 0;
        for (int p = 0; p <= di; p++)
        {
            tot += p;
        }
        return tot;
    }
    /// <summary>
    /// 同上，递归实现
    /// </summary>
    static int Plusd(int d)
    {
        if (d == 1)
        {
            return 1;
        }
        return d + Plusd(d - 1);
    }
}