using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Product
    {
        private string _descripcionProducto = "";

        public void SetDescripcionProducto(string descripcionProducto)
        {
            _descripcionProducto = descripcionProducto;
        }

        public string GetDescripcionProducto()
        { 
            return _descripcionProducto; 
        }
    }
}
