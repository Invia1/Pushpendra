using System;

namespace CheckforShoping
{
    class shop
    {
        double ammount;
        public double cusmoteramount
        {
            get
            {
                return ammount;
            }
            set 
            {
                ammount = value;
                if (ammount > 10000)
                {
                    Console.WriteLine("You are eligable for shopping ");
                }
                else 
                {
                    Console.WriteLine("You are not eligable for shopping ");
                }
            }
        }

    }
    class shopedetails
    {
        public void custominfo()
        {
            shop obj = new shop();
            Console.WriteLine("Enter the amount for shopping");
            obj.cusmoteramount = int.Parse(Console.ReadLine());
        }
         
    }
    class customer
    {

        static void Main(string[] args)
        {
            var obj = new shopedetails();
            obj.custominfo();
        }
    }
}
