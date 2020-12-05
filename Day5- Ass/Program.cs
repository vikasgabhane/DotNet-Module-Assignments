using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArrayAssignmentDay5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size");
            int size = Convert.ToInt32(Console.ReadLine());
            Employee[] emp = new Employee[size];
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine("enter empNo");
                int no = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter empName");
                string name = Console.ReadLine();

                Console.WriteLine("enter basic salary");
                decimal basic = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("enter deptNo");
                int dep = Convert.ToInt32(Console.ReadLine());
                Employee e = new Employee(no, name, basic, dep);
                emp[i] = e;
            }
            decimal arr = emp[0].Pbasic;
            for (int i = 1; i < emp.Length; i++)
            {
                if (arr < emp[i].Pbasic)
                {
                    arr = emp[i].Pbasic;
                }
            }
            Console.WriteLine("highest salary is : " + arr);

            Console.WriteLine("Enter Employee no to be searched");
            int empNo = Convert.ToInt32(Console.ReadLine());
            foreach (Employee e in emp)
            {
                if (e.PempNo == empNo)
                {
                    Console.WriteLine("Empno :=" + e.PempNo + " name=: " + e.Pname + " emp basic:= " + e.Pbasic + " depNo := " + e.PdeptNo);
                }
            }
        }
    }
    public class Employee
    {
        private string name;
        private int empNo;
        private decimal basic;
        private int deptNo;

        public Employee(int empNo, string name, decimal basic, int depNo)
        {

            this.empNo = empNo;

            this.name = name;
            this.basic = basic;
            this.deptNo = depNo;
        }

        #region property
        public string Pname
        {
            set
            {

                if (value.Length != 0)
                {
                    this.name = value;
                }
                else
                {
                    Console.WriteLine("name not be null");
                }
            }
            get
            {
                return name;
            }
        }

        public int PempNo
        {
            get
            {
                return empNo;
            }
        }

        public decimal Pbasic
        {
            set
            {
                if (value >= 25000 && value <= 100000)
                {
                    this.basic = value;

                }
                else
                {
                    Console.WriteLine("enter basic between 25000 to 35000");
                }
            }
            get
            {
                return basic;
            }
        }

        public int PdeptNo
        {
            set
            {
                if (value > 0)
                {
                    this.deptNo = value;
                }
                else
                {
                    Console.WriteLine("deptno must be above 0");
                }
            }
            get
            {
                return deptNo;
            }
        }
        #endregion

    }
}


namespace ArrayAssignmentDay5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 0f batches :");
            int nob = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[nob][];

            for (int i = 0; i < nob; i++)
            {
                Console.WriteLine("Enter Student in {0} batch", i + 1);
                int val = Convert.ToInt32(Console.ReadLine());
                arr[i] = new int[val];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; i < arr[i].Length; j++)
                {
                    Console.WriteLine("Enter marks for batch {0} , student {1} : ", i + 1, j + 1);
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }




        }
    }
}

namespace ArrayAssignmentDay5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter how many student want");
            int size = Convert.ToInt32(Console.ReadLine());


            Student[] s = new Student[size];

            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("Enter Student roll no");
                int no = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Student name");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Student mark");
                decimal mark = Convert.ToDecimal(Console.ReadLine());
                Student s1 = new Student(name, no, mark);
                s[i] = s1;
            }

            foreach (Student a in s)
            {
                Console.WriteLine(a.RNO + " " + a.NAME + " " + a.MARKS);
            }

            Console.ReadLine();

        }
    }
    public struct Student
    {
        private string name;
        private int rno;
        private decimal marks;

        public Student(string name, int rno, decimal marks)
        {

            this.name = name;
            this.rno = rno;
            this.marks = marks;
        }

        public string NAME
        {
            set
            {
                if (value == " " || value == null)
                {

                    Console.WriteLine("name cannot be blank");
                }
                else
                {
                    name = value;
                }
            }
            get
            {
                return name;
            }

        }

        public int RNO
        {
            set
            {
                if (value > 0)
                {

                    Console.WriteLine("EMP no. can be greater thank 0");
                }
                else
                {
                    rno = value;
                }
            }
            get
            {
                return rno;
            }
        }
        public decimal MARKS
        {
            set
            {
                if (value > 40)
                {

                    Console.WriteLine("MARKS can be greater thank 40");
                }
                else
                {
                    marks = value;
                }
            }
            get
            {
                return marks;
            }
        }
    }
}