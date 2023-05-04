using System;

namespace Chetu
{
    class Program
    {
        public string Name;//Instance Field
        public static int population;// static Field
        public  Program(string n)
        {
            Name = n; //Assign the instance field
            population = population + 1;//Increment the static population
        }
       
        
        public static void Main(string[] args)
        {
            Program t1 = new Program("Hardik");
            Console.WriteLine(t1.Name);
            Console.WriteLine(Program.population);
             
        }





    }
    }
       



