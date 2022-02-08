namespace EmployeeRegister {
    class Program {
        static void Main(string[] args) {
            Program.Start();
        }

        static void Start() {
            Employee employee1 = new Employee(1001, "Davies Mark"){
                Department = "Logistics",
                JobTitle = "Driver"
            };

            Employee employee2 = new Employee(1002, "Louis Voutton"){
                Department = "Logistics",
                JobTitle = "Mechanic"
            };

            Employee employee3 = new Employee(1003, "Sarah Levin"){
                Department = "Logistics",
                JobTitle = "Procurement Officer"
            };

            Employee employee4 = new Employee(1004, "Jeff Lewin"){
                Department = "IT",
                JobTitle = "Software Engineer"
            };

            Employee employee5 = new Employee(1005, "Georgina Rodrigues"){
                Department = "Finance",
                JobTitle = "Accountant"
            };

            Records record = new Records(new Employee[]{employee1, employee2, employee3, employee4, employee5});
            record.PrintEmployeeDetail();
        }
    }
}