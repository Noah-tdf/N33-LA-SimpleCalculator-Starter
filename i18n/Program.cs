using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Remoting.Services;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace i18n
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("fr");
            Console.WriteLine(Properties.Resources.EnterFirstNumber);
            Console.WriteLine(Properties.Resources.EnterSecondNumber + Console.ReadLine());
            Console.WriteLine(Properties.Resources.EnterOperation + Console.ReadLine());
            Console.WriteLine(Properties.Resources.DisplayMessage + Console.ReadLine());


        }
    }
}
