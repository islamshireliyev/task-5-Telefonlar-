using System;
using ConsoleApp1.Metodsintro;
using ConsoleApp1;
using ConsoleApp.Phone.System;

namespace ConsoleApp1.PhoneSystem
{
    internal class Program
    {
         static void Main(string[] args)
        {

            #region
            int len;
        l1:
            len = Monitor.ReadInteger("Nece telefon olsun: ");

            if (len <= 0)
            {
                goto l1;
            }

            Phone[] Phone = new Phone[len];
            for (int i = 0; i < Phone.Length; i++)
            {
                Phone phone = new Phone();
                Console.WriteLine($"{i + 1} about in Phone: ");
                phone.Producer = Monitor.ReadString($"Phone producer: ");
                phone.Version = Monitor.ReadString($"Phone Version: ");
                phone.Screen = Monitor.ReadString($"Phone Screen: ");
                phone.mainCamera = Monitor.ReadString($"Phone mainCamera: ");
                phone.operatingSystem = Monitor.ReadString($"Phone operatingSystem: ");
                phone.productionYear = Monitor.ReadString($"Phone productionYear: ");
                phone.Network = Monitor.ReadString($"Phone Network: ");
                phone.Color = Monitor.ReadString($"Phone Color: ");
                phone.Weight = Monitor.ReadString($"Phone Weight: ");

                Phone[i] = phone;
                Console.WriteLine("--------------Next Phone--------------");

            }
            Console.WriteLine("########################List Of Phones##########################");

            foreach (var item in Phone)
            {
                Console.WriteLine(item);
                Console.WriteLine("**********************");
            }



            Console.ReadKey();

            #endregion






        }
    }
}
