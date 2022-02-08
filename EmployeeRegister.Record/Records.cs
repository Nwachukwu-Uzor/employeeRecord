namespace EmployeeRegister {
    class Records {

        private readonly Employee[] _employees;
        public Records(Employee[] employees)
        {
            _employees = employees;
        }

        public Employee[] Employees { get { return _employees; } }

        public void PrintEmployeeDetail() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("(S/N)\tEmployee ID\t\tFull Name\t\tEmployement Date\t\tDepartment\t\tJob Title\n");
            for (int i=0; i < Employees.Length; i++ ) {
                Console.WriteLine($"{i + 1}\t{Employees[i].StaffID}\t\t{Employees[i].FullName}\t\t{Employees[i].EmploymentDate}\t\t{Employees[i].Department}\t\t{Employees[i].JobTitle}\n");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}