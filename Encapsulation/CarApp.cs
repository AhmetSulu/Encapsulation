using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Car
    {
        public string Brand { get; set; } // Herhangi bir veri doğrulama gerekmediği için boş bırakılıyor.
        public double Model { get; set; }
        public string Colour { get; set; }

        private int _doorCount; // Kapsüllenmiş özellik

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
        public Car (string brand, double model, string colour, int _doorCount)
        {
            Brand = brand;
            Model = model;
            Colour = colour;
            DoorCount = _doorCount; // Kapsülleme işlemini kontrol eder
        }

        // Bilgileri yazdıran Metot
        public void ArabaBilgileriniYazdır()
        {
            Console.WriteLine($"Marka: {Brand}, Model: {Model}, Renk: {Colour}, Kapı Sayısı: {DoorCount}");
        }
    }

}
