using SmallEmployeeApp.Models;
using SmallEmployeeApp.Service;

namespace SmallEmployeeApp.UI
{
    public class MainApp
    {
        public static void Main()
        {
            Employee obj = new Employee();
            Employee obj1 = new Employee();
            obj.EID = 101;
            obj.Ename = "Deepti";
            obj.Age = 21;

            obj1.EID = 102;
            obj1.Ename = "Deepak";
            obj1.Age = 24;

            EmployeeService es = new EmployeeService();
            es.CreateEmployee(obj);
            es.CreateEmployee(obj1);
            //Console.WriteLine("Enter the u_id ");
            //int u_id = int.Parse(Console.ReadLine());

            //es.UpdateEmployee( 102);
            es.search(102);


            List<Employee> objList = es.GetEmployeeList();
            foreach (var data in objList)
            {
                Console.WriteLine(data.EID + " " + data.Ename + " " + data.Age);
            }
        }

    }
}
