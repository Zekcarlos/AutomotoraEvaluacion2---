using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Automotora
{
    class Modelo
    {
        public static List<Modelo> items = new List<Modelo>();
        public int ItemId { get; set; }
        public String NameVehiculo { get; set; }
        public int PrecioVehiculo { get; set; }

        public static string[] names = { "Audi", "Toyota", "Hyundai", "Subaru", "Chevrolet", "Mercedez Benz",
                "Suzuki", "Chevrolet", "Volkswagen", "Volvo", "Ford", "Hyundai", "Nissan", "Volvo", "Ford", "BMW",
            "Subaru", "Mazda", "Mercedez Benz", "Suzuki", "Chevrolet" };


        static Random rnd = new Random();
        public Modelo()
        {

        }
        public override string ToString()
        {
            string str = "ID " + ItemId + " MODELO: " + NameVehiculo + " PRECIO: $"+ PrecioVehiculo;
            return str;
        }
        public enum sizes
        {
            CLASE_A = 1, CLASE_B = 2, CLASE_C = 3, CLASE_D = 4
        }
        public Modelo(int id, String name, int price)
        {
            ItemId = id;
            NameVehiculo = name;
            PrecioVehiculo = price;
        }
        public static Modelo fetchItemData(int i)
        {
            int sizeInt = rnd.Next(1, Enum.GetNames(typeof(sizes)).Length+1);
            sizes sizeString = ((sizes)sizeInt);

            int price = rnd.Next(4000000, 10000000);

            Modelo item = new(i, names[i]+" "+sizeString.ToString(), price);
            return item;
        }
        public void listData()
        {
            var query = from item in items
                        orderby item.PrecioVehiculo descending
                        select item;
            foreach (var o in query)
            {
                Console.WriteLine(o.ToString());
            }

        }
    }
}
