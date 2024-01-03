// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;
using EmpManager.entities;
using EmpManager.Controller;

int choice = 1;
while (choice != 0)
{
    Console.WriteLine("***************");
    Console.WriteLine("1.Salary calculation");
    // Console.WriteLine("2.Display Salary ");
    Console.WriteLine("3.Consolidated all employee Total Salary ");
    Console.WriteLine("4.add employee ");
    Console.WriteLine("5.remove employee ");
    // Console.WriteLine("6.find employee ");
    // // Console.WriteLine("7.display employee ");
    // Console.WriteLine("8.Accept salary components from users");
    Console.WriteLine("9.update existing employees salary components");
    Console.WriteLine("0.exit");

    choice = int.Parse(Console.ReadLine());
    EmpController empController = new EmpController();
    switch (choice)
    {
        case 1:
            Console.WriteLine(empController.salaryCalculation(1));
            break;
        case 3:
            Console.WriteLine(empController.allEmpTotalSal());
            Console.WriteLine("sldkfjsldkfj ++++ ==== " + int.Parse(Console.ReadLine()));
            break;
        case 4:
            Console.WriteLine("Enter the employee details: ");
            Console.WriteLine("id , name and base sal:");
            // Employee e3 = new Employee((int.Parse(Console.ReadLine()),Console.ReadLine(),float.Parse(Console.ReadLine())));
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("id migyi...");
            string? name = Console.ReadLine();
            Console.WriteLine("name migyi...");
            float bsal = float.Parse(Console.ReadLine());
            Console.WriteLine("bsal migyi...");
            Employee? e5 = new Employee(id, name, bsal);
            empController.addEmp(e5);
            Console.WriteLine("added successfully...!");
            break;
        case 5:
            Console.WriteLine("to delete enter the emp id: ");
            empController.removeEmp(int.Parse(Console.ReadLine()));
            break;
        case 9:
            Console.WriteLine("enter emp Id and new salary: ");
            empController.updateSalary(int.Parse(Console.ReadLine()),float.Parse(Console.ReadLine()));
            break;
        case 10:
            string s = null;
            string? n = null;
            Console.WriteLine(s);
            Console.WriteLine(n);
        break;
    }
}
