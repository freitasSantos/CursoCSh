using CourseContrato.Classes.Entities;
using System.Collections.Generic;



namespace CourseContrato.Classes {
    class Worker {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public WorkerLevel Level { get; set; }
        public Department department { get; set; }
        public List<Contract> ListContract { get; set; } = new List<Contract>();

        public Worker(string name,double baseSalary,WorkerLevel level,Department departmentt) {
            Name = name;
            BaseSalary = baseSalary;
            Level = level;
            department = departmentt;
        }

        public Worker() {
        }

        public void addContract(Contract obj) {
            ListContract.Add(obj);
        }

        public void removeContract(Contract obj) {
            ListContract.Remove(obj);
        }

        public double income(int month, int year) {
            double salary = BaseSalary;
            foreach(Contract obj in ListContract) {
                if(obj.Date.Month==month && obj.Date.Year == year) {
                    salary += obj.totalValue();
                }
            }
            return salary;
        }

        public override string ToString() {
            return "Name: "+Name+
                   "\nDepartment: "+department.Name;
        }

    }
}
