using System;
using CourseContrato.Classes;
using CourseContrato.Classes.Entities;
using System.Globalization;


namespace CourseContrato {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter department's name: ");
            Department department = new Department(Console.ReadLine());
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level(Junior/MidLeve/Senior): ");
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine());
            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Worker employee = new Worker(name, salary, level, department);
            Console.Write("How many contracts th this worker? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Enter #" + i + " contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double ValueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration( hour ): ");
                int hourContract = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                employee.addContract(new Contract(date, ValueHour, hourContract));
            }
            Console.WriteLine();
            Console.Write("Enter the year and the month to calculate income(MM/YYYY): ");
            string[] yearMonth = Console.ReadLine().Split('/');
            Console.WriteLine(employee);
            Console.WriteLine("Income for " + yearMonth[0] + "/" + yearMonth[1] + ": " +
            employee.income(int.Parse(yearMonth[0]), int.Parse(yearMonth[1])).ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
