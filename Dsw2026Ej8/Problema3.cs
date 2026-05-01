using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copiaValue = originalValue;
            copiaValue++;
            Product product2 = product;
            product2.SetDescripcionProducto("Nuevo");
            return $"{originalValue}-{copiaValue}-{product2.GetDescripcionProducto()}";
        }

    }
}
