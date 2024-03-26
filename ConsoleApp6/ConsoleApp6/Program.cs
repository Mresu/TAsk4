using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Vehicle Vehicle=new Vehicle("BMW", "X5", 500000);
            
        }
    }
    class Vehicle
    {
        public string Brand;
        public string Model;
        public double Mile;
            public Vehicle( string brand,  string model, double mile )
        {
            Brand = brand;
            Model = model;
            
        }
        public void ShowFullName()
        {
            Console.WriteLine(Brand+" "+Model);
        }
    

        
    }
    class Car:Vehicle
    {
        int DoorsNum;
        Car(string brand, string model, double mile):base(brand, model, mile)
        {
            
            DoorsNum = 5;

        }
        public void ShowFullInfo()
        {
            Console.WriteLine(Brand+" "+" "+Model+" "+Mile+" "+DoorsNum);
        }

    }
    class MotorCycle : Vehicle 
    {
        public int WheelNum;
        
        MotorCycle(string brand, string model, double mile):base(brand, model, mile)
        {
            this.WheelNum = 8;
        }
        public void ShowFullInfo()
        {
            Console.WriteLine(this.WheelNum);

        }
    }

}
