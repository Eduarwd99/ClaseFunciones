using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgClaseFunciones
{
    public class MainClass
    {
        /// <summary>
        /// Funcion que determina si un numero es par o impar
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string FnParImpar(int num)
        {
            if (num % 2 == 0) return "Par";
            else return "Impar";
        }

        /// <summary>
        /// Funcion que devuelve el nombre(string) del mes ingresado(int)
        /// </summary>
        /// <param name="mes"></param>
        /// <returns></returns>
        public string FnMeses(int mes)
        {
            if (mes == 1) return "Enero";
            else if (mes == 2) return "Febrero";
            else if (mes == 3) return "Marzo";
            else if (mes == 4) return "Abril";
            else if (mes == 5) return "Mayo";
            else if (mes == 6) return "Junio";
            else if (mes == 7) return "Julio";
            else if (mes == 8) return "Agosto";
            else if (mes == 9) return "Septiembre";
            else if (mes == 10) return "Octubre";
            else if (mes == 11) return "Noviembre";
            else if (mes == 12) return "Diciembre";
            else return "Mes ingresado no valido";
        }
    }
}
