using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Class_Car
{
    internal class Car
    {
        public string city;
        public string name;
        public string model;
        public int year;
        public string type;
        public string color;
        public double engine;
        public double horsePower;
        public string fuelType;
        public int distance;
        public string gearBox;
        public string transmission;
        public string New;
        public int price; 

        public string GetInfo()
        {
            return $"Şəhər: {city} \n" +
             $"Marka: {name} \n" +
             $"Model: {model} \n" +
             $"Buraxılış ili: {year} \n" +
             $"Ban növü: {type} \n" +
             $"Rəng: {color} \n" +
             $"Mühərrik: {engine} \n" +
             $"Mühərrikin gücü: {horsePower} a.g. \n" +
             $"Yanacaq növü: {fuelType} \n" +
             $"Yürüş: {distance} km \n" +
             $"Sürətlər qutusu: {gearBox} \n" +
             $"Ötürücü: {transmission} \n" +
             $"Yeni: {New} \n" +
             $"Qiymət: {price} $";
        }

    }
}
