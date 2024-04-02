using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6Registro.servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int opcionSeleccionada()
        {
            int opcionRespuesta = 0;

            Console.WriteLine(" ");
            Console.WriteLine("#############");
            Console.WriteLine("0. Cerrar");
            Console.WriteLine("1. Modificar Linea");
            Console.WriteLine("2. Insertar texto en un posicion especifica");
            Console.WriteLine("3. Ver contenido archivo");
            Console.WriteLine("4. Guardar");
            Console.WriteLine(" ");

            opcionRespuesta = Convert.ToInt32(Console.ReadLine());
            return opcionRespuesta;
        }
    }
}
