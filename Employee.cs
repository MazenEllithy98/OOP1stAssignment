using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP1stAssignment
{

    //Design and implement a Class for the employees in a company:
    //Employee is identified by an ID, security level, salary, hire date and Gender.
    public class Employee
    {   //Attributes
        private int EmpID;
        private decimal salary;
        private char gender;
        public enum security_privilege 
        {
            Guest = 1, Developer = 2, Secretary = 3, DBA = 4 , Security_Officer = 10
        }
        public security_privilege securityprivilege;

        public Hiring_Date hiringdate1 = new Hiring_Date(1, 1, 1900);
       
        public Employee (int _ID, decimal _salary,int day, int month , int year , char _gender, security_privilege _security)
        {
            EmpID = _ID;
            this.salary = _salary;
            this.gender = _gender;
            this.securityprivilege = _security;
            this.hiringdate1.Day = day;
            this.hiringdate1.Month = month;
            this.hiringdate1.Year = year;

        }
        

        // Encapsulation : Separate Data Definition(Attributes) from its use (Getter Setter) or (Property)
        // Applying Encapsulation using Property and Getter Setter
        
        public int EMPID
        {
            get
            {
                return EmpID;
            }
            set
            { 
                do
                {
                    EmpID = value;

                } while (value >= 0);
            }
        }

        public char Gender
        {
            get { return gender; }
            set
            {
                if (value != 'F' && value != 'M' && value != 'm' && value != 'f')
                {
                    Console.WriteLine("Invalid Gender. Please Enter again.");
                    Console.WriteLine("Please Enter Gender: ");
                    Gender = Convert.ToChar(Console.ReadLine());
                }
                else
                {
                    gender = value;
                }
            }
        }

        public decimal _salary
        {
            get { return salary; }
            set
            {
                while (value >= 0)
                {
                    salary = value;
                }
            }
        }
        
        

        // method
        public override string ToString()
        {
            return $" ID : {EmpID} \n Salary : {salary.ToString("C", new CultureInfo("en-US"))} \n Hire Date : {hiringdate1.Day} / {hiringdate1.Month} / {hiringdate1.Year} \n Gender : {Gender} \n Security Level : {securityprivilege} ";
        }

    }



}
