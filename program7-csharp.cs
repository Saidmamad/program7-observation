using System;

namespace MultilevelInheritance
{
    class Person
    {
        public string Name{ set; get; }
        public string Address { set; get; }
     }

    class Program : Person
    {
        public string Roll { set; get; }

        public void display(Program p)
        {
            Console.WriteLine("Name : " + p.Name);
            Console.WriteLine("Adress : " + p.Address);
            Console.WriteLine("Roll : " + p.Roll);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Name = "Saeed";
            p.Address = "RVS Nagar";
            p.Roll = "15781F0063";
            p.display(p);
            Console.ReadKey();
        }
    }
}
