using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class PersonDetail
{
    List<string> list = new List<string>();
    public void entry()
    {
        char ch;
        do
        {
            Console.WriteLine("Enter the eid,ename,age:");
            list.Add(Console.ReadLine());  //adding the elements
          
            list.Add(Console.ReadLine());
         
            list.Add(Console.ReadLine());
            Console.WriteLine("Do you want to do more entry:(y/n)");
            ch =Convert.ToChar( Console.ReadLine());


        } while (ch=='y' || ch=='Y');

        foreach (var ctr in list)
        {
            Console.Write(ctr + " ");
            
        }
        Console.WriteLine();

    }

    public void entry2()  //Inserting elments
    {
        Console.WriteLine("Where do you wanto insert data :");
        Console.WriteLine("Enter the index value as well as name:");
        
        char ch;

        do
        {
         
            int n = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            list.Insert(n, str);
            Console.WriteLine("Do you enter more record:(y/n)");
             ch=Convert.ToChar( Console.ReadLine());    
            
        } while (ch=='y' || ch=='Y');
        Console.WriteLine("you can not insert more than four ");
         foreach (var ctr in list)
        {
            Console.WriteLine(ctr + " ");
        }
        Console.WriteLine();
    }


    public void Delete()  //deleting elements
    {
        Console.WriteLine("Enter the remove ...");
        string str = Console.ReadLine();
        list.Remove(str);
        
        Console.WriteLine();

        foreach (var ctr in list)
        {
            Console.Write(ctr + " ");
        }
    }

    public void find()  //searching for the elements
    {
        Console.WriteLine("Enter the search elements :");
        string ctr = Console.ReadLine();

        if (list.Contains(ctr))
        {

            Console.WriteLine("search found");
        }

        else
        {
            Console.WriteLine("search not found ");
        }


    }

    public void fetchAll()  //fetchuing the elmentes
    {
        foreach (var ctr in list)
        {
            Console.Write(ctr + " ");
        }
    }
}
class user
{
    public static void Main()
    {
        int n = 0;
        PersonDetail obj = new PersonDetail();

        do
        {
            Console.WriteLine("Which Operation Do youn want perform :");
            string str = Console.ReadLine();
            switch (str)
            {
                case "entry":
                    obj.entry();
                    break;
                case "entry2":
                    obj.entry2();
                    break;
                case "Delete":
                    obj.Delete();
                    break;
                case "find":
                    obj.find();
                    break;
                case "findall":
                    obj.fetchAll();
                    break;
                default:
                    Console.WriteLine("Your keyword is worng ");
                    break;
                 
            }
            n++;
        } while (n>0);
    }
}
