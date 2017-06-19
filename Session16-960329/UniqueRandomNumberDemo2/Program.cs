using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueRandomNumberDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            //Define Domain (Source) Array
            var domain = new int[500000];
            for (int i = 0; i < domain.Length; i++)//پر کردن اعداد دامنه
            {
                domain[i] = 1000000 + i;
            }

            var randomNumbers = new int[300000];//آرایه اعداد تصادفی را تعریف میکنیم
            var r = new Random();

            for (int i = 0; i < randomNumbers.Length; i++)// به ازای آرایه اعداد تصادفی پیمایش میکند
            {
                var randomIndex = r.Next(0, domain.Length - i);//تولید ایندکس تصادفی که در هر مرحله بازه انتخاب آن یک واحد کمتر میشود
                randomNumbers[i] = domain[randomIndex];//انتقال عدد تصادفی بع آرایه اعداد تصادفی
                domain[randomIndex] = domain[domain.Length - 1 - i];//انتقال خانه آخر نسبی به خانه ای که عدد تصادفی را از آن برداشتیم
            }
            sw.Stop();

            Array.Sort(randomNumbers);
            foreach (var number in randomNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("-----------------------");
            Console.WriteLine(sw.Elapsed);

            Console.ReadKey();
        }
    }
}
