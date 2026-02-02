// For studying polymorphism - Code written by Brother Burton in the BYU CSE 210 instructions

using System;

class Program
{
    static void Main(string[] args)
    {
        HourlyEmployee hEmployee = new HourlyEmployee();
        hEmployee.SetName("John");
        hEmployee.SetIdNumber("123abc");
        hEmployee.SetPayRate(15);
        hEmployee.SetHoursWorked(35);

        SalaryEmployee sEmployee = new SalaryEmployee();
        sEmployee.SetName("Peter");
        sEmployee.SetIdNumber("456def");
        sEmployee.SetSalary(60000);

        Console.WriteLine("The static void method that's outside the Main method:");
        DisplayEmployeeInformation(hEmployee);
        DisplayEmployeeInformation(sEmployee);

        List<Employee> employees = new List<Employee>();
        employees.Add(hEmployee);
        employees.Add(sEmployee);

        Console.WriteLine("The foreach loop that's inside the Main method:");

        // Code written in a generic way that can apply to all employees, but the specific version that gets called is the appropriate one for each derived type.
        foreach (Employee emp in employees)
        {
            float pay = emp.GetPay();
            Console.WriteLine($"{emp.GetName()} will be paid ${pay}");
        }
    }

    public static void DisplayEmployeeInformation(Employee employee)
    {
        float pay = employee.GetPay();
        Console.WriteLine($"{employee.GetName()} will be paid ${pay}");
    }
}