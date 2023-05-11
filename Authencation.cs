using System;
class Demo
{
    public static  bool Authenticate(string username, string password)
    {
        if (username == "admin" && password == "admin")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
   public   static void Main()
        
    {
        int count = 0;
        char ch;
        do
        {

            if (count < 3)
            {
                
                Console.WriteLine("Enter the username and userpassword");
                string u_name = Console.ReadLine();

                string u_password = Console.ReadLine();

                bool res = Authenticate(u_name, u_password);
                if (res == true)
                {
                    Console.WriteLine("Login Successfully");
                    break;
                }
                else
                {
                    Console.WriteLine("Login failled");
                }
            }
            else
            {
                Console.WriteLine("Try again after some time");
                break;
            }
            count++;
            Console.WriteLine("Do you want to check again");
            ch =Convert.ToChar( Console.ReadLine());
          


        } while (ch=='y' || ch=='Y');
        

    }
      
    }

