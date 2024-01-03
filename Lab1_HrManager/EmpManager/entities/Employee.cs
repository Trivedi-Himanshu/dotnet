using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpManager.entities
{
    public class Employee
    {
        public int Id{get; set;}
        public float BasicSal{get; set;}
        public float Tax{get; set;}
        public float Da{get; set;}
        public float Pf{get; set;}
        public string? Name{get; set;}

        public Employee(){
            Id = 0;
            BasicSal = 0;
            Tax = 0;
            Da = 0;
            Pf = 0;
            Name = null;
        }
        public Employee(int id,String name,float basicSal){
            Id = id;
            BasicSal = basicSal;
            Tax = (float)0.15;
            Da = (float)200;
            Pf = (float)0.2;
            Name = name;
        }
        public override string ToString()
        {
            return "Id: "+Id+"  Name: "+Name+"  sal: "+BasicSal;
        }
    }
}