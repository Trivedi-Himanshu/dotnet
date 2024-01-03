using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpManager.entities;
using EmpManager.Services;

namespace EmpManager.Controller
{
    public class EmpController
  {
        IEmpService _svc;
        public EmpController(){
            _svc = new EmpService();
        }
        public float salaryCalculation(int id){
            return _svc.salaryCalculation(id);
        }

        public float allEmpTotalSal(){
            return _svc.allEmpTotalSal();
        }
        public void addEmp(Employee e){
            _svc.addEmp(e);
        }
        public Employee removeEmp(int id){
            return _svc.removeEmp(id);
        }
        public Employee updateSalary(int id, float BasicSal){
            return _svc.updateSalary(id , BasicSal);
        }
    }
}