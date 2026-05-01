using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            double sumaNotas = 0;
            int cantidadNotas = 0;

            if(nota1.HasValue && nota1 <= 10 && nota1 >= 0)
            {
                sumaNotas += nota1.Value;
                cantidadNotas++;
            }

            if(nota2.HasValue && nota2 <= 10 && nota2 >= 0)
            {
                sumaNotas += nota2.Value;
                cantidadNotas++;
            }

            if(nota3.HasValue && nota3 <= 10 && nota3 >= 0)
            {
                sumaNotas += nota3.Value;
                cantidadNotas++;
            }

            if (cantidadNotas == 0)
                return 0;

            return sumaNotas / cantidadNotas;
        }
    }
}
