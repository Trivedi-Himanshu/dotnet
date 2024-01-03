using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using EmpManager.entities;

namespace EmpManager.Repository
{
    public class EmpRepository
    {
        public void Serialize(List<Employee> employees,string fileName){
            var options  = new JsonSerializerOptions{IncludeFields=true};
            var empJson = JsonSerializer.Serialize<List<Employee>>(employees,options);
            File.WriteAllText(fileName,empJson);
        }

        public List<Employee> DeSerialize(string fileName){
            string jsonString = File.ReadAllText(fileName);
            List<Employee> jsonEmployees = JsonSerializer.Deserialize<List<Employee>> (jsonString);
            return jsonEmployees;
        }
    }
}