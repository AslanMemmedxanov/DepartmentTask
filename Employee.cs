using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPARTMENT
{
    //public class Employee
    //{
    //    public string Number { get; set; }
    //    public string FullName { get; set; }
    //    private string Position;

    //    public string position
    //    {
    //        get { return position; }
    //        set
    //        {
    //            if (value.Length >= 2)
    //            {
    //                position = value;
    //            }
    //        }
    //    }
    //    private double Salary;

    //    public double salary
    //    {
    //        get { return salary; }
    //        set
    //        {
    //            if (value >= 250)
    //            {
    //                salary = value;

    //            }
    //            else
    //                throw new ArgumentOutOfRangeException("MAAS minumum 250 AZN olmalidir!");
    //        }
    //    }
    //    public string DepartmentName { get; set; }


    //}
    //public class Department
    //{
    //    private string Name;

    //    public string name
    //    {
    //        get { return name; }
    //        set
    //        {
    //            if (value.Length >= 2)
    //            {
    //                name = value;
    //            }
    //            else throw new ArgumentOutOfRangeException("NAME minumum 2 herfli olmalidir!");
    //        }
    //    }

    //    private int WorkerLimit;
    //    public int workerlimit
    //    {
    //        get { return workerlimit; }
    //        set
    //        {
    //            if (value >= 1)
    //            {
    //                workerlimit = value;
    //            }
    //        }
    //    }
    //    private decimal SalaryLimit;
    //    public decimal salarylimit
    //    {
    //        get { return salarylimit; }
    //        set
    //        {
    //            if (value >= 2)
    //            {
    //                salarylimit = value;
    //            }
    //            else throw new ArgumentOutOfRangeException("Minumum 250 olmalidir!");
    //        }
    //    }
    //    public List<Employee> Employees { get; set; } = new List<Employee>();

    //    public double CalcSalaryAverage()
    //    {
    //        if (Employees.Count == 0)
    //            return 0;
    //        double totalSalary = 0;
    //        foreach (Employee employee in Employees)
    //        {
    //            totalSalary += employee.salary;

    //        }
    //        return totalSalary / Employees.Count;

    //    }
    //}

    //public interface IHumanResourceManager
    //{
    //    List<Department> Departments { get; set; }

    //    void AddDepartment(string name, int workerLimit, decimal salarylimit);

    //    List<Department> GetDepartments();
    //    void EditDepartment(string name, string newName);
    //    void AddEmployee(string FullName, string position, decimal salary, string DepartmentName);
    //    void RemoveEmployee(string DepartmentName, string employeeNo);
    //    void EditEmployee(string employeeName, string FullName, decimal salary, string position);
    //}

    public class Employee
    {
        public string No { get; set; }
        public string Fullname { get; set; }
        public string Position { get; set; }
        private decimal salary;
        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 250)
                {
                    throw new Exception("Salary cannot be less than 250");
                }
                salary = value;
            }
        }
        public string DepartmentName { get; set; }
    }

    public class Department
    {
        public string Name { get; set; }
        public int WorkerLimit { get; set; }
        public decimal SalaryLimit { get; set; }
        public List<Employee> Employees { get; set; }
        public decimal CalcSalaryAverage()
        {
            decimal totalSalary = 0;
            foreach (Employee employee in Employees)
            {
                totalSalary += employee.Salary;
            }
            return totalSalary / Employees.Count;
        }
    }

    public interface IHumanResourceManager
    {
        List<Department> Departments { get; }
        void AddDepartment(string name, int workerLimit, decimal salaryLimit);
        List<Department> GetDepartments();
        void EditDepartment(string name, string newName);
        void AddEmployee(string fullname, string position, decimal salary, string departmentName);
        void RemoveEmployee(string departmentName, string employeeNo);
        void EditEmployee(string employeeNo, string fullname, decimal salary, string position);
    }

    
}


