using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotora
{
    class Local
    {
        public static List<Local> stores = new List<Local>();
        public int StoreId { get; set; }
        public String Retiro { get; set; }
        public Local()
        {

        }
        public override string ToString()
        {
            string str = "ID: " + StoreId + " Local de retiro: " + Retiro + " ";
            return str;
        }
        public Local(int id, String address)
        {
            StoreId = id;
            Retiro = address;
        }
        public static Local fetchStoreData(int i)
        {
            string[] addressList = {"987 quilicura", "999 Conchali", "1570 Tomás Moro", "Vicuña Mackenna 1207", "Los Pajaritos 3302", "Américo Vespucio 6325", "Oriental 6958", "Carrascal 6450",
                "Independencia 3187", "Vitacura 8751", "Las Garzas 845", "Antumalal 589", "777 Los Andés", "888 Los baldios", "California 754", "147 Angora",
                "matta 800", "555 Los angeles", "774 Agustina", "654 San fernando", "987 quilicura"};

            Local store = new(i, addressList[i]);
            stores.Add(store);
            return store;
        }
        public void listData()
        {
            var query = from store in stores
                        orderby store.StoreId ascending
                        select store;
            foreach (var o in query)
            {
                Console.WriteLine(o.ToString());
            }
        }
    } }
    
