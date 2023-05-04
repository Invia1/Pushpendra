using System;

class person     
{
    

    public static void Main()
    {
        Console.WriteLine("Enter the number please");
        string str= Console.ReadLine();
        int l = str.Length,i;
        for ( i = 0; i < l / 2; i++)
        {
            if (str[i] != str[l - 1 - i])
            {
                
                break;
            }
        }
        if (i == l / 2)
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("Not a pp");
        }
        

    }



}

