using CourseContrato.Classes.Entities;
using System.Collections.Generic;



namespace CourseContrato.Classes {
    class Worker {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public WorkerLevel Level { get; set; }
        public Department department { get; set; }
        List<Contract> ListContract = new List<Contract>();

        public Worker(string name,double baseSalary,WorkerLevel level,Department departmentt) {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.Level = level;
            this.department = departmentt;
        }

        public Worker() {
        }

        
    }
}
