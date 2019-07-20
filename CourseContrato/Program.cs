using System;
using CourseContrato.Classes.Entities;
using CourseContrato.Classes;
using System.Collections.Generic;


namespace CourseContrato {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter department`s name: ");
            string department = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Level(Junior/MidLeve/Senior): ");
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel),Console.ReadLine());

            
        }
    }
}
