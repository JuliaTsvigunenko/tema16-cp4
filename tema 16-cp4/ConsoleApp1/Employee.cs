using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {

        /// <summary>
        /// Поле табельного номера
        /// </summary>
        private int personnelNumber;

        /// <summary>
        /// Поле ФИО сотрудника
        /// </summary>
        private string fullName;

        /// <summary>
        /// Поле дата рождения сотрудника
        /// </summary>
        private DateTime birthday;

        /// <summary>
        /// Поле должности сотрудника
        /// </summary>
        private string jobTitle;

        /// <summary>
        /// Поле оклада сотрудника
        /// </summary>
        private int salary;


        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="personnelNumber"></param>
        /// <param name="fullName"></param>
        /// <param name="birthday"></param>
        /// <param name="jobTitle"></param>
        /// <param name="salary"></param>
        public Employee(int personnelNumber, string fullName, DateTime birthday, string jobTitle, int salary)
        {
            this.personnelNumber = personnelNumber;
            this.fullName = fullName;
            this.birthday = birthday;
            this.jobTitle = jobTitle;
            this.salary = salary;

        }


        /// <summary>
        /// Поле свойства для доступа к полям Гет и Сет
        /// </summary>
        public int PersonnelNumber { get { return personnelNumber; } set { personnelNumber = value; } }
        public string FullName { get { return fullName; } set { fullName = value; } }
        public DateTime Birthday { get { return birthday; } set { birthday = value; } }
        public string JobTitle { get { return jobTitle; } set { jobTitle = value; } }
        public int Salary { get { return salary; } set { salary = value; } }


        /// <summary>
        /// Метод для вывода данных о сотруднике
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine($"\tТабельный номер: {personnelNumber}\n ФИО сотрудника: {fullName}\n Дата рождениясотрудника: {birthday}\n Должность сотрудника: {jobTitle}\n Оклад сотрудника: {salary}");

        }



























    }
}
