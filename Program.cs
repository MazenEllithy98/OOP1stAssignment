using System.ComponentModel;
using System.Linq;

namespace OOP1stAssignment
{
    
    internal class Program
    {
      
        static void Main(string[] args)
        {
            
            var employee = new Employee(1,2000,1,1,2000,'f',Employee.security_privilege.Guest);
            Hiring_Date hiringdate = new Hiring_Date(1,1,1900);
            Employee[] EmpArr = new Employee[3];
            EmpArr[0] = new Employee(1, 2000, 1, 1, 2000, 'f', Employee.security_privilege.Guest);
            
            EmpArr[1] = new Employee(2, 15000, 1, 11, 2019, 'M', Employee.security_privilege.DBA);
            
            EmpArr[2] = new Employee(3, 20_000, 1, 1, 2018, 'm', Employee.security_privilege.Security_Officer);
            

            var sorted = EmpArr.OrderBy(ob=>ob.hiringdate1.Year).ToArray();
            Array.ForEach(sorted, Console.WriteLine);

           
        }
    }
}