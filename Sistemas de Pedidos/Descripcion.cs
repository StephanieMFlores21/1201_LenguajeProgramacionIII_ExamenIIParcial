using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemas_de_Pedidos
{
    class Descripcion
    {
        //PROPIEDADES
        public string NombreCliente { get; set; }
        public string Direccion { get; set; }
        public string Presentacion { get; set; }
        public string Medicamento { get; set; }
        public string TipoMedicamento { get; set; }
        public int PrecioProd { get; set; }
        public int CantidadProd { get; set; }
        public int TotalaPagar { get; set; }

        //CONSTRUCTORES
        public Descripcion() { }

        public Descripcion(string _nombrecliente, string _direccion, string _presentacion, string _medicamento, string _tipomedicamento, int _precioprod, int _cantidadprod, int _totalaPagar)
        {
            //PROPIEDAD IGUAL A PARAMETROS
            NombreCliente = _nombrecliente;
            Direccion = _direccion;
            Presentacion = _presentacion;
            Medicamento = _medicamento;
            TipoMedicamento = _tipomedicamento;
            PrecioProd = _precioprod;
            CantidadProd = _cantidadprod;
            TotalaPagar = _totalaPagar;
        }
    }
}
