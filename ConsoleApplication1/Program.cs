using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    #region test1

    //class Program
    //{
    //    //创建计时器
    //    private static readonly Stopwatch Watch = new Stopwatch();

    //    private static void Main(string[] args)
    //    {
    //        //启动计时器
    //        Watch.Start();

    //        const string url1 = "http://www.cnblogs.com/";
    //        const string url2 = "http://www.cnblogs.com/liqingwen/";

    //        //两次调用 CountCharactersAsync 方法（异步下载某网站内容，并统计字符的个数）
    //        Task<int> t1 = CountCharactersAsync(1, url1);
    //        Task<int> t2 = CountCharactersAsync(2, url2);

    //        //三次调用 ExtraOperation 方法（主要是通过拼接字符串达到耗时操作）
    //        for (var i = 0; i < 3; i++)
    //        {
    //            ExtraOperation(i + 1);
    //        }

    //        //控制台输出
    //        Console.WriteLine($"{url1} 的字符个数：{t1.Result}");
    //        Console.WriteLine($"{url2} 的字符个数：{t2.Result}");
    //        Console.WriteLine("sssss");
    //        Console.Read();
    //    }

    //    /// <summary>
    //    /// 统计字符个数
    //    /// </summary>
    //    /// <param name="id"></param>
    //    /// <param name="address"></param>
    //    /// <returns></returns>
    //    private static async Task<int> CountCharactersAsync(int id, string address)
    //    {
    //        var wc = new WebClient();
    //        Console.WriteLine($"开始调用 id = {id}：{Watch.ElapsedMilliseconds} ms");

    //        var result = await wc.DownloadStringTaskAsync(address);
    //        Console.WriteLine($"调用完成 id = {id}：{Watch.ElapsedMilliseconds} ms");

    //        return result.Count();
    //    }

    //    /// <summary>
    //    /// 额外操作
    //    /// </summary>
    //    /// <param name="id"></param>
    //    private static void ExtraOperation(int id)
    //    {
    //        //这里是通过拼接字符串进行一些相对耗时的操作
    //        var s = "";

    //        for (var i = 0; i < 6000; i++)
    //        {
    //            s += i;
    //        }

    //        Console.WriteLine($"id = {id} 的 ExtraOperation 方法完成：{Watch.ElapsedMilliseconds} ms");
    //    }
    //}
    #endregion

    #region test2

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        const int num = 1000000;
    //        var t = DoStuff.Yield1000(num);

    //        Loop(num / 10);
    //        Loop(num / 10);
    //        Loop(num / 10);

    //        Console.WriteLine($"Sum: {t.Result}");

    //        Console.Read();
    //    }

    //    /// <summary>
    //    /// 循环
    //    /// </summary>
    //    /// <param name="num"></param>
    //    private static void Loop(int num)
    //    {
    //        for (var i = 0; i < num; i++) ;
    //    }
    //}

    //internal static class DoStuff
    //{
    //    public static async Task<int> Yield1000(int n)
    //    {
    //        var sum = 0;
    //        for (int i = 0; i < n; i++)
    //        {
    //            sum += i;
    //            if (i % 1000 == 0)
    //            {
    //                await Task.Yield(); //创建异步产生当前上下文的等待任务
    //            }
    //        }

    //        return sum;
    //    }
    //}

    #endregion

    #region test3

    //class Program
    //{
    //    public static void Main()
    //    {
    //        var aaa = new A();
    //        for (int i = 0; i < 10; i++)
    //        {
    //            aaa.SetArray(i, i);
    //        }


    //        foreach (var item in aaa)
    //        {
    //            Console.WriteLine(item);
    //        }

    //        Console.ReadLine();
    //    }

    //    class A : IEnumerable
    //    {

    //        private int[] array = new int[10];
    //        public void SetArrays(int[] data)
    //        {
    //            for (int i = 0; i < data.Length; i++)
    //            {
    //                if (i < 10)
    //                    array[i] = data[i];
    //                else
    //                    break;
    //            }
    //        }

    //        public void SetArray(int data, int index)
    //        {
    //            if (index < 10 && index >= 0)
    //            {
    //                array[index] = data;
    //            }
    //        }
    //        public IEnumerator GetEnumerator()
    //        {
    //            for (int i = 0; i < 10; i++)
    //            {
    //                if (i < 8)
    //                {
    //                    yield return array[i];
    //                }
    //                else
    //                {
    //                    yield break;
    //                }
    //            }
    //        }
    //    }
    //}

    #endregion

    #region test4

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        A a = new A();
    //        a.AA();
    //        Console.ReadLine();
    //    }        
    //}

    //class A
    //{

    //    public async void AA()
    //    {
    //        await DoDialogAsync();
    //    }
    //   public async Task DoDialogAsync()
    //    {
    //        //var dialog = new Form();
    //        System.Diagnostics.Debug.WriteLine("");

    //        Func<Task> showAsync = async () =>
    //        {
    //            await Task.Yield();
    //            //dialog.ShowDialog();
    //            Console.WriteLine("showAsync-1");
    //            Thread.Sleep(1000);
    //            Console.WriteLine(1);
    //            Thread.Sleep(1000);
    //            Console.WriteLine(2);
    //            Thread.Sleep(1000);
    //            Console.WriteLine(3);
    //            Console.WriteLine("Sleep-1");
    //        };

    //        var dialogTask = showAsync();
    //        await Task.Yield();

    //        Console.WriteLine("showAsync-2");
    //        Thread.Sleep(1000);
    //        Console.WriteLine("Sleep-2");

    //        await dialogTask;
    //        // we're back to the main message loop  
    //        Console.WriteLine("showAsync-3");
    //        Thread.Sleep(1000);
    //        Console.WriteLine("Sleep-3");
    //    }
    //}

    #endregion

    #region test5

    class Program
    {
        static void Main(string[] args)
        {
            //var asasdas = GetA<A>();
            //Console.WriteLine(2);
            //var asdasjjj = asasdas.Result.AA;
            //Console.WriteLine(3);

            var t = typeof(A);
            object entity = t.Assembly.CreateInstance(t.FullName);

            jjj<A>();


            Console.ReadLine();
        }

        public static void jjj<T>()
        {
            Console.WriteLine("jjj");
        }

        public async static Task<T>  GetA<T>()where T:class
        {
            await Task.Yield();

            return default(T);
        }
        
    }

    public class A
    {
        public A()
        {
            Console.WriteLine("init");
        }
        public string AA { get; set; } = "323";
    }

    #endregion
    }
