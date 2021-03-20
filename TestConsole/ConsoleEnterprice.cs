using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting;
using Drivers;

namespace TestConsole
{
    public class ConsoleEnterprice
    {
        Enterprice factory = new Enterprice();
        public void Menu()
        {
            
            while (true)
            {
                
                
                    Console.WriteLine("\tМеню");
                    Console.WriteLine("0. Выйти.");
                    Console.WriteLine("1. Добавить водителя.");
                    Console.WriteLine("2. Добавить машину.");
                    Console.WriteLine("3. Добавить путевой лист.");
                    Console.WriteLine("4. Вывод всего.");
                    Console.WriteLine("5. Вывод затрат по всем рейсам.");
                if (!int.TryParse(Console.ReadLine(), out int choise))
                    Console.WriteLine("Ошибка! Введите номер варианта меню.");
                else if (choise == 1)
                    if (AddDriver())
                        Console.WriteLine("Успешно!");
                    else
                        Console.WriteLine("Ошибка!");
                else if (choise == 2)
                    if (AddCar())
                        Console.WriteLine("Успешно!");
                    else
                        Console.WriteLine("Ошибка!");
                else if (choise == 3)
                    if (AddWayBill())
                        Console.WriteLine("Успешно!");
                    else
                        Console.WriteLine("Ошибка!");
                else if (choise == 4)
                    ShowAllInfo();
                else if (choise == 5)
                    GetCostOfAll();

                else if (choise == 0)
                    break;
                

            }
        }
        public bool AddDriver()
        {
            Console.WriteLine("Введите идентификатор водителя: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ФИО водителя: ");
            string FIO = Console.ReadLine();
            ClassOfDriver q = ClassOfDriver.first;
            Console.WriteLine("Выберите квалификацию водителя: first, second, third.");
            string qu = Console.ReadLine();
            if (qu == "second")
                q = ClassOfDriver.second;
            else if(qu == "third")
                q = ClassOfDriver.third;
            return factory.AddDriver(id, FIO, q);     
        }
        public bool AddCar()
        {
            Console.WriteLine("Введите тип машины: BUS, MINIBUS, TRUCK.");
            string type = Console.ReadLine();
            if (type == "BUS")
            {
                Console.WriteLine("Введите идентификатор, расход, пассажироемкость и грузоподъемность.");
                return factory.AddBus(Convert.ToInt32(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            }
            else if (type == "TRUCK")
            {
                Console.WriteLine("Введите идентификатор, расход и грузоподъемность.");
                return factory.AddTruck(Convert.ToInt32(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            }
            else if (type == "MINIBUS")
            {
                Console.WriteLine("Введите идентификатор, расход и пассажироемкост.");
                return factory.AddMiniBus(Convert.ToInt32(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            }
            else return false;
        }
        public bool AddWayBill()
        {
            Console.WriteLine("Введите водителя, дистанцию, дату, номер водителя и номер машины. ");
            return factory.AddWayBill(Console.ReadLine(), Convert.ToDouble(Console.ReadLine()), Convert.ToDateTime(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
        }
        public void ShowAllInfo()
        {
            Console.WriteLine("Список водителей: ");
            Console.WriteLine(factory.driversList.ToString());
            Console.WriteLine("Список машин: ");
            Console.WriteLine(factory.carList.ToString());
            Console.WriteLine("Список путевых листов");
            Console.WriteLine(factory.waybillList.ToString());

        }
        public void GetCostOfAll()
        {
            for (int i=0; i< factory.waybillList.Count; i++)
            {
                Console.WriteLine(factory.waybillList[i].ToString() + "\nЗатраты: " + factory.GetCost(factory.waybillList[i]));
            }
            Console.WriteLine("Итого: " + factory.GetFullCost());
        }
    }
}
