using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadito
{
    public class Inventario
    {
        private int _id;
        private string _nombre;
        private double _precio;
        private int _cantidad;

        public int Id1 { get => _id; set => _id = value; }
        public string Nombre1 { get => _nombre; set => _nombre = value; }
        public double Precio1 { get => _precio; set => _precio = value; }
        public int Cantidad1 { get => _cantidad; set => _cantidad = value; }

        public Inventario()
        {
            _id = 0;
            _nombre = "";
            _precio = 0.0;
            _cantidad = 0;
        }
        

        public Inventario(
            int id,
            string nombre,
            double precio,
            int cantidad
            )
        {
            _id = id;
            _nombre = nombre;
            _precio = precio;
            _cantidad = cantidad;
        }
    }
}
