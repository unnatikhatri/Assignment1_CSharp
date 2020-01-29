using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromactInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Id :");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name :");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Department Name :");
            string deptName = Console.ReadLine();

            Employee emp = new Employee(id, name, deptName);

            Console.WriteLine("Employee ID : {0}", emp.GetId());
            Console.WriteLine("Employee Name : {0}", emp.GetName());
            Console.WriteLine("Employee Department Name : {0}", emp.GetDeptName());

        }

    }
}
