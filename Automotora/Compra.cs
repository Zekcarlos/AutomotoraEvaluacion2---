using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotora
{
    class Compra
    {
        public int IdFinal { get; set; }
        public int PrecioFinal { get; set; }
        public String VehiculoCom { get; set; }
        public String LocalRetiro { get; set; }
        public Compra()
        {

        }
        public override string ToString()
        {
            string str = " ID DE LA COMPRA:" + IdFinal + " LOCAL DE RETIRO " + LocalRetiro + ", VEHICULO COMPRADO: " + VehiculoCom + ", PRECIO TOTAL $" + Convert.ToInt32(PrecioFinal);
            return str;
        }
        public Compra(int id, int cost, String products, String store)
        {
            IdFinal = id;
            PrecioFinal = cost;
            VehiculoCom = products;
            LocalRetiro = store;
        }
        public static Compra createCompra(int id, int cost, String products, string store)
        {
            Compra compra = new(id, cost, products, store);
            return compra;
        }
    }
}
