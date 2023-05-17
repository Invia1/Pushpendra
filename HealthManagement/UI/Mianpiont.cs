using System;
using System.Runtime.CompilerServices;
using HealthManagement.Model;
using HealthManagement.Model;
using HealthManagement.Services;

namespace HealthManagement.UI
{
    internal class Mainpoint
    {

        public static void Main()
        {
            int i = 0;
           
            char ch;

            PaitentOperations obj=new PaitentOperations();

            List<Paitent> item = obj.GetPaintentList();
            Paitent obj1 = new Paitent();

            do
            {

             
                Console.WriteLine("Enter the First Name");
                obj1.First_name = Console.ReadLine();
                Console.WriteLine("Enter the Second Name");
                obj1.Last_name = Console.ReadLine();
                Console.WriteLine("Enter the Gender(M/F)");
                obj1.Gender = Console.ReadLine();
                Console.WriteLine("Enter the Age Plaese :");
                obj1.Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Address Plaese :");
                obj1.Address = Console.ReadLine();
                Console.WriteLine(" Enter your mobile number");
                obj1.PhoneNO = Console.ReadLine();
               
                Console.WriteLine("Do you want to add more registraction :");
                ch = Convert.ToChar(Console.ReadLine());
                i++;
                obj1.Pid = i;

            } while (ch == 'y' || ch == 'Y');

            obj.registration(obj1);
            Console.WriteLine(" ");
            Console.WriteLine("Yor resgistred record is :");
            foreach (Paitent p in item)
            {
                Console.WriteLine(p.Pid+" "+p.First_name+" "+p.Last_name+" "+p.Age+" "+p.Gender+" "+p.PhoneNO);
            }
            Console.WriteLine("Paintent wants consult with :");
            Console.WriteLine("1.General Medication");
            Console.WriteLine("1.Dental");
            Console.WriteLine("3.Orthopaedics");
            Console.WriteLine(" ");
            obj1.Consulted = Console.ReadLine();

          
         
           

            if (obj1.Consulted=="General Mediction")
            {
                obj.GeneralMediction();
            }
            else if (obj1.Consulted=="Dental")
            {
                obj.Dental();
            }
            else if (obj1.Consulted == "Orthopaedics")
            {
                obj.Orthopaedics();
            }
            else 
            {
                Console.WriteLine("Specialist is not persent now ");
            }





        }
}
}
