using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadTrajes;
            double precioUnitario;
            double subtotal;
            double descuento;
            double totalAPagar;

            Console.Write("Ingrese la cantidad de trajes: ");
            cantidadTrajes = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio unitario: ");
            precioUnitario = double.Parse(Console.ReadLine());

            subtotal = cantidadTrajes * precioUnitario;
            descuento = 0;

            if (cantidadTrajes == 1)
            {
                descuento = subtotal * 0.5;
            }
            else if (cantidadTrajes == 2)
            {
                descuento = subtotal * 0.55;
            }
            else if (cantidadTrajes == 3)
            {
                descuento = subtotal * 0.6;
            }
            else if (cantidadTrajes > 3)
            {
                descuento = subtotal * 0.65;
            }

            totalAPagar = subtotal - descuento;

            Console.WriteLine("Subtotal: $" + subtotal);
            Console.WriteLine("Descuento: $" +descuento);
            Console.WriteLine("Total a pagar: $" + totalAPagar);
        }
    }
}