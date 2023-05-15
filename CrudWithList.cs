using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class personDetails
{
    List<object> objList = new List<object>();

    public void storeproduct()
    {
        Console.WriteLine("Enter the how many product you want to add: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the your products :");
        object[] item = new object[n];
        for (int i = 0; i < n; i++)
        {
            objList.Add(item[i] = Console.ReadLine());

        }
        Console.WriteLine("Your products is :");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(i+":" + item[i]);
        }

   }
    public void Remove()
    {
        char ch;
        do
        {
            Console.WriteLine("Which products  do you want to remove from shop:");
            Console.WriteLine();
            Console.WriteLine("Enter the number of the products :");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < objList.Count; i++)
            {
                if (objList[i] == objList[n])
                {
                    objList.Remove(objList[n]);
                    break;
                }
                else
                {
                    Console.WriteLine("Your products are found");
                    break;
                }

            }
            Console.WriteLine(" Left your products  are : ");
            foreach (object obj in objList)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Do you want to remove another products :(y/n)");
            ch=Convert.ToChar(Console.ReadLine()); 
        } while (ch=='y' && ch=='Y');
    }
    public void  find()
    {
        
        Console.WriteLine("Which products do you want to see:");
        string str = Console.ReadLine();
        Console.WriteLine("Your products is :");
       
        bool res=objList.Contains(str);
        if (res == true)
        {
            Console.WriteLine(objList);
        }
        else
        {
            Console.WriteLine("Your products is not find :");
        }
    }

}

class user
{
    public static void Main()
    {
        personDetails obj = new personDetails();
        obj.storeproduct();
        obj.Remove();
        obj.find();
    
    }
}

