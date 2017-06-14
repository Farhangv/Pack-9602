using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleReadWriteDemo
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //توضیحات یک خطی
            Console.WriteLine("Hello C#");//کانت در انتهای خط
            /*
             * توضیحات چند
             * خطی
             * 
             */
            Console.WriteLine("Welcome To C#"/*خوش آمد گویی به سی شارپ*/);
            SendSMS("3213213", "jhgjhghjghjghjgjh", "hjgjhghjg");
            Console.ReadKey();
        }

        /// <summary>
        /// این تابع برای ارسال پیامک استفاده میشود
        /// </summary>
        /// <param name="senderNumber">شماره ارسال کننده</param>
        /// <param name="message">متن پیام</param>
        /// <param name="recepientNumber">شماره دریافت کننده</param>
        static void SendSMS(string senderNumber, string message, string recepientNumber)
        {

        }
    }
}

