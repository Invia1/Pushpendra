using System;
using System.Net.Sockets;

class person     
{
    



    public static void Main()
    {
        Console.WriteLine("Enter the string :");
        string str = Console.ReadLine();
        char[] charArr = str.ToCharArray();
        int[] visited = new int[26];
        for (int i = 0; i < charArr.Length; i++)
        {
            if (visited[charArr[i] - 'a'] == 1)
            {
                continue;
            }
            int count = 0;
            visited[charArr[i] - 'a'] = 1;
            for (int j = 0; j < charArr.Length ; j++)
            {
                if (charArr[i] == charArr[j])
                {
                    count++;
                }
            }
            Console.WriteLine(charArr[i]+"is present "+count+"in a word");
        }
       

    }



}

