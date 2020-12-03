using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignmentDay4
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneralManager gm = new GeneralManager("vikas", 5, 30000, "SE", "nothing");
            Console.WriteLine("Net Salary = "+gm.CalcNetSalary());
            gm.showDetails();

            Console.WriteLine();

            CEO ceo = new CEO();
            Console.WriteLine("Net Salary = " + ceo.CalcNetSalary());
            ceo.showDetails();

            Console.ReadLine();
        }
    }

    public interface IDbFunctions
    {
        void showDetails();
    }

    

    public abstract class Employee : IDbFunctions
    {
        private string Name;
        private int EmpNo;
        private short DeptNo;
        public decimal Basic;
        private static int cnt;

        public Employee(string Name = "EmpName", short DeptNo = 10, decimal Basic = 25000)
        {
            EmpNo = ++cnt;
            this.Name = Name;
            this.DeptNo = DeptNo;
            this.Basic = Basic;
        }

        public int EMPNO
        {
            get
            {
                return EmpNo;
            }
        }

        public string NAME
        {
            set
            {
                if (value != null)
                    Name = value;
                else
                    Console.WriteLine("Name cannot be null");
            }
            get
            {
                return Name;
            }
        }

        public short DEPTNO
        {
            set
            {
                if (value > 0)
                    DeptNo = value;
                else
                    Console.WriteLine("DeptNo should be greater than zero");
            }
            get
            {
                return DeptNo;
            }
        }

        public abstract decimal BASIC
        {
            set;
            get;
        }

        public abstract decimal CalcNetSalary();

        public void showDetails()
        {
            Console.WriteLine("Emp No = " + EMPNO);
            Console.WriteLine("Emp Name = " + NAME);
            Console.WriteLine("DeptNo = " + DEPTNO);
            Console.WriteLine("Basic Sal = " + BASIC);
        }
    }

    

    public class Manager : Employee,IDbFunctions
    {
        private string Designation;
        public Manager(string Name = "EmpName", short DeptNo = 10, decimal Basic = 25000, string Designation = "NoDesignation") : base(Name, DeptNo, Basic)
        {
            this.Designation = Designation;
        }

        public string DESIGNATION
        {
            set
            {
                if (value != null)
                    Designation = value;
                else
                    Console.WriteLine("Designation cannot be empty");
            }
            get
            {
                return Designation;
            }
        }

        public override decimal BASIC
        {
            set
            {
                if (value > 0 && value < 100000)
                    Basic = value;
                else
                    Console.WriteLine("Basic Sal should be in range between 0 to 100000");
            }
            get
            {
                return Basic;
            }
        }

        public override decimal CalcNetSalary()
        {
            return BASIC + 2000;
        }

        public new void showDetails()
        {
            Console.WriteLine("Emp No = " + EMPNO);
            Console.WriteLine("Emp Name = " + NAME);
            Console.WriteLine("DeptNo = " + DEPTNO);
            Console.WriteLine("Basic Sal = " + BASIC);
            Console.WriteLine("Designation = " + DESIGNATION);
        }
    }

   

    public class GeneralManager : Manager,IDbFunctions
    {
        private string Perks;

        public GeneralManager(string Name = "EmpName", short DeptNo = 10, decimal Basic = 25000, string Designation = "NoDesignation", string Perks = "none") : base(Name, DeptNo, Basic, Designation)
        {
            this.Perks = Perks;
        }

        public string PERKS
        {
            set
            {
                Perks = value;
            }
            get
            {
                return Perks;
            }
        }

        public new void showDetails()
        {
            Console.WriteLine("Emp No = " + EMPNO);
            Console.WriteLine("Emp Name = " + NAME);
            Console.WriteLine("DeptNo = " + DEPTNO);
            Console.WriteLine("Basic Sal = " + BASIC);
            Console.WriteLine("Designation = " + DESIGNATION);
            Console.WriteLine("Perks = "+ PERKS);
        }
    }

    

    public class CEO : Employee,IDbFunctions
    {
        public override decimal BASIC
        {
            set
            {
                if (value > 30000 && value < 100000)
                    Basic = value;
                else
                    Console.WriteLine("Basic Sal should be in range between 30000 to 100000");
            }
            get
            {
                return Basic;
            }
        }

        public sealed override decimal CalcNetSalary()
        {
            return BASIC + 5000;
        }

        public new void showDetails()
        {
            Console.WriteLine("Emp No = " + EMPNO);
            Console.WriteLine("Emp Name = " + NAME);
            Console.WriteLine("DeptNo = " + DEPTNO);
            Console.WriteLine("Basic Sal = " + BASIC);
          
        }
    }

}
