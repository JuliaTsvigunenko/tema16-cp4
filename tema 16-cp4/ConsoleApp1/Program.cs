using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Создаем объекты сотрудников
            //Employees employees1 = new Employees(1, "Цвигуненко Юлия Владимировна", new DateTime(2006, 5, 19), "Дизайнер", 10000);
            //Employees employees2 = new Employees(2, "Лебедева Серафима Игоревна", new DateTime(2007, 7, 1), "Программист", 10000);
            //Employees employees3 = new Employees(3, "Крижановская Арина Владимировна", new DateTime(2006, 5, 17), "Повар", 10000);

            //Console.WriteLine("Информация о сотруднике 1: ");
            //employees1.ShowInfo();

            //Console.WriteLine("Информация о сотруднике 2: ");
            //employees2.ShowInfo();

            //Console.WriteLine("Информация о сотруднике 3: ");
            //employees3.ShowInfo();



            // Создать массив из N объектов данной структуры.
            // Сведения об объектах вывести в табличном виде.
            // В случае отсутствия информации об объектах, вывести соответствующее сообщение.

            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            Employee[] emp = new Employee[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Инфомация о сотруднике {i + 1}: ");
                Console.Write("Табельный номер: ");
                int personnelNumber = int.Parse(Console.ReadLine());
                Console.Write("ФИО сотрудника: ");
                string fullName = Console.ReadLine();
                Console.Write("Дата рождения: ");
                DateTime birthday = DateTime.Parse(Console.ReadLine());
                Console.Write("должность: ");
                string jobTitle = Console.ReadLine();
                Console.Write("оклад: ");
                int salary = Convert.ToInt32(Console.ReadLine());

                emp[i] = new Employee(personnelNumber, fullName, birthday, jobTitle, salary);

            }


            Console.ReadKey();





        }
    }
}
