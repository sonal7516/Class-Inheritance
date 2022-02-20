using System;

namespace Copy_Constructor
{
    class VisitingEmployee : Employee
    {
        public int Dura;

        public void Data (int time)
        {
            this.Dura = time;

            Console.WriteLine("Contract Duration:{0}", this.Dura);

        }

    }
    class PermanentEmployee : Employee
    {
        int hrs;

        public int Data2(int hr)
        {
            this.hrs = hr;
            return hr;
        }
        
           
    }

    class Employee
    {
        public string EmpName;
        public int EmpId;
        public int EmpAge;

        public void setData(string name, int id, int age)
        {
            this.EmpName = name;
            this.EmpId = id;
            this.EmpAge = age;
        }

        public void getData()
        {
            Console.WriteLine("Employee name is:{0}", EmpName);
            Console.WriteLine("Employee ID is:{0}", EmpId);
            Console.WriteLine("Employee age is:{0}", EmpAge);
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            VisitingEmployee Deepti = new VisitingEmployee();
            Deepti.setData("Deepti", 123, 25);
            Deepti.getData();
            Deepti.Data(6);

            Console.WriteLine("-------------");

            PermanentEmployee Sonal = new PermanentEmployee();
            Sonal.setData("Sonal", 143, 26);
            Sonal.getData();
            Console.WriteLine("Working hours:" + Sonal.Data2(9) );

            Console.WriteLine("----------------");

            Employee Anuj = new Employee();
            Anuj.setData("ANUJ", 1432, 28);
            Anuj.getData();
            
            

            Console.ReadLine();
        }
    }
}
