using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpManager.entities;

namespace EmpManager.Controller
{
    public interface IEmpController
    {
        float salaryCalculation(int Id);
        float allEmpTotalSal();
        void addEmp(Employee e);
        Employee removeEmp(int id);
        Employee findEmp(int id);
        Employee displayEmp(int id);
        void updateSalary(int id, float sal);

    }
}