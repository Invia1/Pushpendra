using System;
using SmallEmployeeApp.Models;


namespace SmallEmployeeApp.Service
{
    public class EmployeeService
    {

        List<Employee> objList=new List<Employee>();
          public int CreateEmployee(Employee emp)
          {
            objList.Add(emp);
            return 1;
          }

          public List<Employee> GetEmployeeList()
          {
            return objList;
          }
        public void  UpdateEmployee(int id )
        {

            foreach (var item in objList)
            {
                if (item.EID == id)
                {
                    Console.WriteLine("Do you want to update Ename as well as Age ");
                    item.Ename = Console.ReadLine();
                    item.Age=int.Parse(Console.ReadLine());
                    
                   
                }


            }
            Console.WriteLine("After updation list items :");
            GetEmployeeList();
          }
        public void search(int id )
        {
            foreach (var item in objList)
            {
                if (item.EID == id)
                {
                   

                    Console.WriteLine(item.EID + " " + item.Ename + " " + item.Age);


                }


            }
        }
    }
}
