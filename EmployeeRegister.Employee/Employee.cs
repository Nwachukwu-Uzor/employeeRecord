namespace EmployeeRegister {
    class Employee {
        private readonly int _staffID;
        private readonly string _fullName;

        private readonly DateTime _employmentDate;

        public Employee(int staffID, string fullname)
        {
            _staffID = staffID;
            _fullName = fullname;
            _employmentDate = DateTime.Now;
        }

        public int StaffID { get {return _staffID; } }

        public DateTime EmploymentDate {get {return _employmentDate; }}

        public string FullName { get {return _fullName; } }

        public string Department { get; set; }

        public string JobTitle {get; set; }

        public void ClockIn() {
            Console.WriteLine($"{FullName} has clocked in");
        }
        public void ClockOut() {
            Console.WriteLine($"{FullName} has clocked out");
        }
        public void Work() {
            Console.WriteLine($"{FullName} is working");
        }
    }
}