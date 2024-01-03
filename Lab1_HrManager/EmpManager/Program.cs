// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;
using EmpManager.entities;
using EmpManager.Controller;

int choice = 1;
while (choice != 0)
{
    Console.WriteLine("***************");
    Console.WriteLine("1.Salary calculation");
    Console.WriteLine("2.Display Salary ");
    Console.WriteLine("3.Consolidated all employee Total Salary ");
    Console.WriteLine("4.add employee ");
    Console.WriteLine("5.remove employee ");
    Console.WriteLine("6.find employee ");
    Console.WriteLine("7.display employee ");
    Console.WriteLine("8.Accept salary components from users");
    Console.WriteLine("8.Accept salary components from users");
    Console.WriteLine("9.update existing employees salary components");
    Console.WriteLine("0.exit");
    
    choice  = int.Parse(Console.ReadLine());
    switch(choice){
        case 1:
            EmpController empController = new EmpController();
            break;
    }
}
