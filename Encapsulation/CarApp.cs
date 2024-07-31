using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Car
    {
        public string _brand;
        public double _model;
        public string _color;

        private int _doorCount; // Kapsüllenmiş özellik

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public double Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        // Kapı Sayısı özelliği için özel get ve set
        public int DoorCount 
        {
            get { return _doorCount; }
            set
            {
                if (value == 2 || value == 4)
                {
                    _doorCount = value;
                }
                else
                {
                    Console.WriteLine("Geçersiz kapı sayısı.(-1).");
                    _doorCount = -1;
                }
            }
        }
        // Yapıcı metot (Constructor)
        public Car (string brand, double model, string color, int _doorCount)
        {
            _brand = brand;
            _model = model;
            _color = color;
            DoorCount = _doorCount; // Kapsülleme işlemini kontrol eder
        }

        // Bilgileri yazdıran Metot
        public void PrintCarDetails()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Color: {Color}, Door Count: {DoorCount}");
        }
    }

}
