using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgClaseFunciones.MainClass op = new ProgClaseFunciones.MainClass();
            Console.WriteLine("Ingrese un numero entero");
            string num = Console.ReadLine();
            int x = Convert.ToInt32(num);
            string valor = op.FnParImpar(x);
            Console.WriteLine("El numero <{0}> es {1}", x, valor);
            Console.ReadKey();

            ProgClaseFunciones.MainClass op2 = new ProgClaseFunciones.MainClass();
            Console.WriteLine("Ingrese el numero del mes correspondiente entre 1 y 12");
            string mes = Console.ReadLine();
            int y = Convert.ToInt32(mes);
            string valor2 = op2.FnMeses(y);
            Console.WriteLine("El mes numero <{0}> representa al mes de {1}", y, valor2);
            Console.ReadKey();
        }
    }
}
