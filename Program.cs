////Arapova
////HW
////1
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Modul_8HW
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            SqrdArr squaredArray = new SqrdArr(6);
//            squaredArray[0] = 1;
//            squaredArray[1] = 2;
//            squaredArray[2] = 3;
//            squaredArray[3] = 4;
//            squaredArray[4] = 5;
//            squaredArray[5] = 6;


//            for (int i = 0; i < 6; i++)
//            {
//                Console.WriteLine($"Значение элемента  = {squaredArray[i]}");
//            }

//            Console.ReadKey();


//        }

//        class SqrdArr
//        {
//            private int[] array;

//            public SqrdArr(int size)
//            {
//                array = new int[size];
//            }

//            public int this[int index]
//            {
//                get
//                {
//                    if (index >= 0 && index < array.Length)
//                    {
//                        return array[index];
//                    }
//                    else
//                    {
//                        throw new IndexOutOfRangeException();
//                    }
//                }
//                set
//                {
//                    if (index >= 0 && index < array.Length)
//                    {
//                        array[index] = value * value;
//                    }
//                    else
//                    {
//                        throw new IndexOutOfRangeException();
//                    }
//                }
//            }
//        }

//    }
//}

//2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_8HW
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите площадь: ");
            double area = double.Parse(Console.ReadLine());

            Console.Write("Введите кол. людей: ");
            int people = int.Parse(Console.ReadLine());

            Console.Write("Сезон: ");
            string season = Console.ReadLine().ToLower();

            Console.Write("Льготы: ");
            string Sale = Console.ReadLine().ToLower();

            double heating = 3.0;
            double water = 5.0;
            double gas = 6.0;
            double repair = 5.0;

            if (season == "осень" || season == "зима")
            {
                heating *= 1.2;
            }

            double heatingPay = area * heating;
            double waterPay = people * water;
            double gasPay = people * gas;
            double repairPay = area * repair;

            double salee = 0.0;

            if (Sale == "да")
            {
                salee = heatingPay * 0.3;
            }

            double totalHeating = heatingPay- salee;
            double totalWater = waterPay;
            double totalGas = gasPay;
            double totalRepair = repairPay;
            double totalPay = totalHeating + totalWater + totalGas + totalRepair;

            Console.WriteLine("Вид платежа\t\tНачислено\tЛьготная скидка\tИтого");
            Console.WriteLine($"Отопление\t\t{heatingPay:C}\t\t{salee:C}\t\t{totalHeating:C}");
            Console.WriteLine($"Вода\t\t\t{waterPay:C}\t\t\t-\t\t{totalWater:C}");
            Console.WriteLine($"Газ\t\t\t{gasPay:C}\t\t\t-\t\t{totalGas:C}");
            Console.WriteLine($"Ремонт\t\t\t{repairPay:C}\t\t\t-\t\t{totalRepair:C}");
            Console.WriteLine($"Итого\t\t\t\t{totalPay:C}");

            Console.ReadKey();
        }
    }
}

