using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpManager.Services;

namespace EmpManager.Controller
{
    public class EmpController
    {
        public EmpController(){
            IEmpService _svc = new EmpService();
        }
        // public float salaryCalculation(int id){

        // }

        
    }
}