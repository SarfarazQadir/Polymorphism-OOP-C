using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism__OOP_
{
    internal class Vehical
    {
        // POLYMORPHISM METHOD OVERLOADING
        void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        void Sum(float a, float b)
        {
            Console.WriteLine(a + b);
        }
        public void color(string color3 = "White", string color4 = "Blue")
        {
            Console.WriteLine(color3 + color4);
        }
    }
     
    // POLYMORPHISM METHOD OVERRIDING

    class car : Vehical
    {
        
        public void color( string color3 = "White", string color4 = "Black")
        {
            Console.WriteLine(color3 + color4);
        }
        static void Main(string[] args)
        {
            car color= new car();
            color.color();
            Console.ReadLine();
            /*Vehical car = new Vehical();
            car.Sum(30.4f, 20.3f);
            Console.ReadLine();*/
        }
    }
}
