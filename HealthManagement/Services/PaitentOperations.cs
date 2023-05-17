using System;
using HealthManagement.Model;
namespace HealthManagement.Services
{
    internal class PaitentOperations
    {
        List<Paitent> paitents = new List<Paitent>();
        Paitent obj = new Paitent();
        public int registration(Paitent p)
        {
            paitents.Add(p);
            return 1;
        }

        public List<Paitent> GetPaintentList()
        {
            return paitents;
        }

        public void GeneralMediction()
        {
            Console.WriteLine("Yes, I am GenralMediction ");
        }
        public void Orthopaedics()
        {
            Console.WriteLine("Yes, I am Orthopaedics");
        }
        public void Dental()
        {
            Console.WriteLine("Yes ,I am dental");
        }

    }
}
