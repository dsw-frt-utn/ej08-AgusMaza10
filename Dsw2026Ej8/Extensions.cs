using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Dsw2026Ej8
{
    public static class Extensions
    {
        public static string ToProductCode(this string code)
        {
            if (code is null)
                return "SIN-CODIGO";
            else
            {
                string result = code;
                result = result.Trim();
                result = result.ToUpper();
                result = result.Replace(" ","-");
                return result;
            }
        }
    }
}
