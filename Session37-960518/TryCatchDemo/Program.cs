using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var month = int.Parse(Console.ReadLine());
                //var num2 = int.Parse(Console.ReadLine());

                if (month < 0)
                {
                    //throw new Exception("Sen Be mah va bozorgtar az 0 ast!");
                    throw new InvalidAgeException();
                }

                Console.WriteLine(month / 12);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Noe Dade Vorudi Bayad adad bashad");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("adad ra bar sefr taghsim nakonid");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("adade vorudi az mahdude adade mojaz kharej shode");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Khatayi rokh dade");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();

            }

        }
    }
}
