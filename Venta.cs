using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadito
{
    public class Venta
    {
       private int _id;
       private DateTime _fecha;
       private double _total;

        public int Id { get => _id; set => _id = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public double Total { get => _total; set => _total = value; }


        public Venta()
        {
            _id = 0;
            _fecha = DateTime.Now;
            _total = 0.0;
        }

        public Venta(
            int id,
            DateTime fecha,
            double total
            )
        {
            _id = id;
            _fecha = fecha;
            _total = total;
        }
    }
}
