using System;


class EmployeApp
{
    public int EmployeeID { get; set; }
    string EmployeeName;
    public int EmployeeAge { get; set; }
    public string EmpName
    {
        get
        { 
            return EmployeeName;
        }
        set 
        {
            
            EmployeeName = value;
            
        }

    }
}  

class Hr
{
    EmployeApp obj = new EmployeApp();
    public EmployeApp employeeDetail()
    {

       validName();

      return obj;

    }
    public void validName()
    {
        int count = 0;
        char ch;
        do
        {
            if (count < 3)
            {
                Console.WriteLine("Enter the string please :");
                string res = Console.ReadLine();
                string res1 = "";
                if (res == res1)
                {
                    Console.Write("Enter your name please :");

                }
                else if (res == res.ToLower())
                {
                    res = res.ToUpper();
                    obj.EmpName = res;
                }
            }
            else
            {
                Console.WriteLine("fill after some time ");
                break;
            }
            Console.WriteLine("Do you want fill again(y\n)");
           
            ch = Convert.ToChar(Console.ReadLine());
            count++;

        } while (ch =='y' || ch == 'Y');
       
    }
    public static void Main()
    {
        Hr obj = new Hr();
        EmployeApp temp = obj.employeeDetail();
        Console.WriteLine(temp.EmployeeID + " " + " " + temp.EmpName + " " + temp.EmployeeAge);
    }
}
