using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1

            /*int a = Convert.ToInt32((Console.ReadLine()));
            int b = Convert.ToInt32((Console.ReadLine()));
            int count = 0;
            int sum = 0;
            for (int x = a; x < b; x++)
                if (x % 3 == 0)
                {
                    count = count + 1;
                }
            Console.WriteLine(count);
            Console.ReadKey();*/

            //Task2

            /*string str = "dasfasjpfgasjpgraeawsh";
            for (int i = 1; i < str.Length; i += 2)
            {
                Console.WriteLine(str[i]);
            }
            Console.ReadKey();*/

            //Task3

            /*string drink = Console.ReadLine();
            switch (drink)
            {
                case "Coffee":
                case "Кава":
                    Console.WriteLine(" Кава коштує 50 грн");
                    break;
                case "Tea":
                case "Чай":
                    Console.WriteLine("Чай коштує 15 грн");
                    break;
                case "Juice":
                case "Сік":
                    Console.WriteLine("Сік коштує 30 грн");
                    break;
                case "Watter":
                case "Вода":
                    Console.WriteLine(" Вода коштує 20 грн");
                    break;
            }
            Console.ReadKey();*/

            //Task4

            /*int i = 0;
            int num;
            int sum = 0;
            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
                i++;
            }
            while (num > 0);
            double res = (double)(sum - sum) / (i / i);
            Console.WriteLine(res);*/


            /*int num;
            int sum = 0;
            int count = 0;
            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
                count++;
            }
            while (num > 0);
            double avarage = (double)(sum - sum) / (count - 1);
            Console.WriteLine(avarage);
            Console.ReadKey();*/

            //Task5

            /*int year;
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
                if (year % 100 != 0)
                    Console.WriteLine(" Цей рік - високосний");
            else
                Console.WriteLine("Цей рік - не високосний");
            Console.ReadKey();*/

            //Task6

            /*string num = Console.ReadLine();
            int sum = 0;
            foreach (char p in num)
            {
                sum += Convert.ToInt32(p.ToString());
            }
            Console.WriteLine(sum);
            Console.ReadKey();*/

            //Task7

            /*string num = Console.ReadLine();
            int count = 0;
            foreach (char p in num)
            {
                if (p % 2 != 0)
                    count++;
                else
                    break;
            }
            if (count == num.Length)
                Console.WriteLine("Непарними є всі числа");
            else
                Console.WriteLine("Непарними є не всі числа");
            Console.ReadKey();*/

            //Task8

            /*string golosni = Console.ReadLine();
            int a_gl = 0;
            int o_gl = 0;
            int i_gl = 0;
            int e_gl = 0;
            for( int g = 0; g < golosni.Length; g++)
            {
                switch(golosni[g])
                {
                    case 'a':
                    case 'а':
                        a_gl += 1;
                        break;
                    case 'o':
                    case 'о':
                        o_gl += 1;
                        break;
                    case 'i':
                    case 'і':
                        i_gl += 1;
                        break;
                    case 'e':
                    case 'е':
                        e_gl += 1;
                        break;
                }
            }
            Console.WriteLine($"a: {a_gl} o: {o_gl} i: {i_gl} e: {e_gl}");
            Console.WriteLine($"Їх сума: {a_gl + o_gl + i_gl + e_gl}");
            Console.ReadKey();*/

            //Task9

            /*Console.WriteLine("Введіть від 1 до 12, також є 2v");
            string mounth = Console.ReadLine();
            switch(mounth)
            {
                case "1":
                case "3":
                case "5":
                case "7":
                case "8":
                case "10":
                case "12":
                    Console.WriteLine("Цей місяць має 31 день");
                    break;
                case "4":
                case "6":
                case "9":
                case "11":
                    Console.WriteLine("Цей місяць має 30 днів");
                    break;
                case "2":
                    Console.WriteLine("Цей місяць має 28 днів");
                    break;
                case "2v":
                    Console.WriteLine("В цьому місяці 29 днів");
                    break;
            }
            Console.ReadKey();*/
        }
    }
}