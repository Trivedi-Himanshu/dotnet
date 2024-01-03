using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpManager.entities;
using EmpManager.Repository;
using EmpManager.Services;
namespace EmpManager.Services
{
    public class EmpService: IEmpService
    {
        public EmpRepository _repo ;
        public EmpService(){
            _repo = new EmpRepository();
        }
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

        public float salaryCalculation(int id){
            List<Employee> employees = _repo.DeSerialize("empJsonFile1");
            Employee? emp = employees.Find(e=> e.Id == id);
            return emp.Da*23+emp.BasicSal+emp.Pf-emp.Tax;
        }
        public float allEmpTotalSal(){
            List<Employee> employees = _repo.DeSerialize("empJsonFile1");
            float totalSal=0; 
            employees.ForEach(emp=> totalSal +=(emp.Da*23+emp.BasicSal+emp.Pf-emp.Tax));
            return totalSal;
        }
        public void addEmp(Employee e){
            List<Employee> employees = _repo.DeSerialize("empJsonFile1");
            employees.Add(e);
            _repo.Serialize(employees,"empJsonFile1");
            return ;
        }
        public Employee removeEmp(int id){
            List<Employee> employees = _repo.DeSerialize("empJsonFile1");
            Employee e = employees.Find(e=> e.Id==id);
            employees.Remove(e);
            _repo.Serialize(employees,"empJsonFile1");
            return e;
        }
        public Employee findEmp(int id){
            return null;
        }
        public Employee displayEmp(int id){
            return null;
        }
        public Employee updateSalary(int id,float sal){
            List<Employee> employees = _repo.DeSerialize("empJsonFile1");
            Employee emp = employees.Find(e=> e.Id==id);
            employees.Remove(emp);
            emp.BasicSal=sal;
            employees.Add(emp);
            _repo.Serialize(employees,"empJsonFile1");
            return emp;
        }
    }
}