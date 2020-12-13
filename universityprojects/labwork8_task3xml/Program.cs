using System;
using System.IO;
using System.Xml.Serialization;

namespace labwork8_task3xml
{
    [Serializable]
    public class Car
    {
        public Int32 carId;
        public decimal price;
        public Int32 quantity;
        public decimal total;
        public Car() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //object for serialization
            Car car = new Car();
            car.carId = 210723;
            car.price = 4008842;
            car.quantity = 4;
            car.total = 8;

            XmlSerializer formatter = new XmlSerializer(typeof(Car));

            //where should we write serialized object
            using (FileStream filestream = new FileStream("cars.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(filestream, car);

                Console.WriteLine("The Object was serialized");
            }

            //deserialization from file car.xml

            using (FileStream filestream = new FileStream("cars.xml", FileMode.OpenOrCreate))
            {
                Car newCar = (Car)formatter.Deserialize(filestream);

                Console.WriteLine("The Object was deserialized");

                Console.WriteLine($"\tID: {newCar.carId}, Price: {newCar.price}, Quantity: {newCar.quantity}, Total: {newCar.total}");

            }

            Console.ReadLine();
        }
    }
}