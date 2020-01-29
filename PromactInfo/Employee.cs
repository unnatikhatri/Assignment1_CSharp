using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromactInfo
{
    class Employee
    {
        private int id;
        private string name;
        private string deptName;

        public Employee(int id, string name, string dept)
        {
            this.id = Id;
            this.name = Name;
            this.deptName = DeptName;
        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string DeptName
        {
            get
            {
                return deptName;
            }
            set
            {
                deptName = value;
            }
        }


        public int GetId()
        {
            return Id;
        }
        public string GetName()
        { 
            return Name;
        }
        public string GetDeptName()
        {
            return DeptName;
        }
        public string GetDeptName(string dept)
        {
            return dept;
        }

        public string GetDeptName(string existingDept, string newDept)
        {
            return newDept;
        }

        public string GetDeptName(string dept, int id)
        {
            return dept; ;
        }
    }
}
