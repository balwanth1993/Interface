using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Interface
{
    interface IEmployee
    {
        void EmployeeId(int id);
        void EmployeeName(string emp);
    }
    abstract public class Employee : IEmployee
    {
        public abstract void EmployeeId(int id);

        public void EmployeeName(string emp)
        {
            Console.WriteLine("Employee name is " + emp);
        }

    }
    interface Icustomer
    {
        void DepositMoney();
        void WithDrawMoney();
    }

    public class Banking : Employee, Icustomer
    {
        public void DepositMoney()
        {
            Console.WriteLine("Your Money has been Deposited");
        }

        public override void EmployeeId(int id)
        {
            Console.WriteLine("Your Employee Id is " +id);
        }

        public void WithDrawMoney()
        {
            Console.WriteLine("Your Money has been Withdrawn");
        }

        class Program
        {
            static void Main(string[] args)
            {
                Banking bnk = new Banking();
                bnk.EmployeeId(1);
                bnk.EmployeeName("Balwanth");
                bnk.DepositMoney();
                bnk.WithDrawMoney();
            }
        }
    }
}