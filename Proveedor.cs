using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadito
{
    public class Proveedor
    {

        private int _id;
        private string _nombre;
        private string _telefono;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }


        public Proveedor()
        {
            _id = 0;
            _nombre = "";
            _telefono = "";
        }

        public Proveedor(
            int id,
            string nombre,
            string telefono
            )
        {
            _id = id;
            _nombre = nombre;
            _telefono = telefono;
        }
    }
}
