class Program
{
    public static void prime()
    {
        int n, i, m = 0, flag = 0;
        Console.WriteLine("Enter the Number to check Prime: ");
        n = int.Parse(Console.ReadLine());
        m = n / 2;
        for (i = 2; i <= m; i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine("Number is not Prime.");
                flag = 1;
                break;
            }
        }
        if (flag == 0)
            Console.WriteLine("Number is Prime.");
    }
    public static void factorial()
    {
        int i, fact = 1, number;
        Console.WriteLine("Enter any Number: ");
        number = int.Parse(Console.ReadLine());
        for (i = 1; i <= number; i++)
        {
            fact = fact * i;
        }
        Console.WriteLine("Factorial of " + number + " is: " + fact);

    }
    public static void fibonacci()
    {
        int n1 = 0, n2 = 1, n3, i, number;
        Console.WriteLine("Enter the number of elements: ");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine(n1 + " " + n2 + " "); //printing 0 and 1    
        for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
        {
            n3 = n1 + n2;
            Console.WriteLine(n3 + " ");
            n1 = n2;
            n2 = n3;
        }
    }
    static void Main(string[] args)
    {
        int n = 0;
        do {
            
            string monthNumber;
            Console.WriteLine(" Enter the your only given below predefined  keyword like : ");
            Console.WriteLine(" 1:" + "prime");
            Console.WriteLine(" 2:" +  "factorail");
            Console.WriteLine(" 3:" +  "fibonacci");
            Console.Write("Your choice is :");
         


            monthNumber = Console.ReadLine();

            switch (monthNumber)
            {
                case "prime":
                    prime();

                    break;
                case "factorail":
                    factorial();
                    break;
                case "fibonacci":
                    fibonacci();
                    break;
                

            }
            n++;
            Console.WriteLine("Enter the only predefined keyword :");

        } while (n>0);


       Console.ReadLine();

    }
}
