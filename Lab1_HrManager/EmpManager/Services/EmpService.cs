using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpManager.entities;
using EmpManager.Repository;

namespace EmpManager.Services
{
    public class EmpService: IEmpService
    {
        //to add json format data into the file 
        // public EmpService(){
        //     EmpRepository _repo = new EmpRepository();
        //     List<Employee> employees = new List<Employee>();
        //     employees.Add(new Employee(1,"Albert",50000));
        //     employees.Add(new Employee(2,"Robert",60000));
        //     employees.Add(new Employee(3,"Krishna",70000));
        //     employees.Add(new Employee(4,"Mayur",80000));
        //     employees.Add(new Employee(5,"Manas",90000));

        //     _repo.Serialize(employees,"empJsonFile1");
        // }

        public EmpService(){
            EmpRepository _repo = new EmpRepository();
        }
        public float slaryCalculation(int id){
            
        }
    }
}