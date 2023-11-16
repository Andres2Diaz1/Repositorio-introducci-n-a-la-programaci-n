using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese sus valores");

            Console.WriteLine("Ingresar velocidad final");
            double vf = 0; vf = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresar velocidad inicial");
            double vo = 0; vo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("tiempo");
            double t = 0; t = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("aceleracion");
            double a = 0; a = Convert.ToDouble(Console.ReadLine());

            // Ingresar "0" si en cuyo caso no se quiera agregar un valor a una variable

            if ( vf == 0 && vo == 0 && a == 0 && t == 0)
            {
                Console.WriteLine("Error números incorrectos");
            }
            else if (vo == 0)
            {
                vo = (vf / t) - a;
                Console.WriteLine("Su velocidad inicial es de:  " + vo + " m/s");
            }
            else if (t == 0)
            {
                t = (vf - vo) / a;
                Console.WriteLine("Su tiempo en segundos es de:  " + t + " s");
            }
            else if (a == 0)
            {
                a = (vf - vo) / t;
                Console.WriteLine("Su velocidad es de: " + a + " m/s2");
            }
            else if (vf == 0) 
            {
                vf = vo + a * t;
                Console.WriteLine("Su velocidad final es de:  " + vf + " m/s");
            }
            else 
            {
                Console.WriteLine("Error en llenar los datos");          
            }


            Console.ReadKey();
        }
    }
}
