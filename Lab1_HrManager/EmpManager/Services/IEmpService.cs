using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpManager.entities;

namespace EmpManager.Services
{
    public interface IEmpService
    {
        float salaryCalculation(int id);
        float allEmpTotalSal();
        void addEmp(Employee e);
        Employee removeEmp(int id);
        Employee findEmp(int id);
        Employee displayEmp(int id);
        Employee updateSalary(int id,float sal);
    }
}