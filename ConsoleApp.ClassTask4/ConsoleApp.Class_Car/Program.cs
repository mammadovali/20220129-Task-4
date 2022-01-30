using System;
using System.Text;

namespace ConsoleApp.Class_Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Car bmw = new Car();

            bmw.city = "Bakı";
            bmw.name = "BMW";
            bmw.model = "M5";
            bmw.year = 2014;
            bmw.type = "Sedan";
            bmw.color = "Boz";
            bmw.engine = 4.4;
            bmw.horsePower = 575;
            bmw.fuelType = "Benzin";
            bmw.distance = 96000;
            bmw.gearBox = "Avtomat";
            bmw.transmission = "Arxa";
            bmw.New = "Xeyr";
            bmw.price = 55000;

            Car landRover = new Car();
            landRover.city = "Bakı";
            landRover.name = "Land Rover";
            landRover.model = "RR Sport";
            landRover.year = 2019;
            landRover.type = "Offroader / SUV";
            landRover.color = "Qırmızı";
            landRover.engine = 3.0;
            landRover.horsePower = 360;
            landRover.fuelType = "Benzin";
            landRover.distance = 6500;
            landRover.gearBox = "Avtomat";
            landRover.transmission = "Tam";
            landRover.New = "Xeyr";
            landRover.price = 105000;

            Car[] cars = new Car[2];

            cars[0] = bmw;
            cars[1] = landRover;

            foreach (Car item in cars)
            {
                Console.WriteLine(item.GetInfo());
                Console.WriteLine("--------");
                
            }







        }
    }
}
