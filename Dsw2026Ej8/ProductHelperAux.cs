using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public partial class ProductHelper
    {
        private string FormatoEtiqueta(long code, string description, decimal price)
        {
            return $"{code}, {description} - {price:C2}";
        }
    }
}