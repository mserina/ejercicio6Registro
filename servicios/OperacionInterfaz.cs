using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6Registro.servicios
{
    internal interface OperacionInterfaz
    {
        public string[] modificarLineaEspecifica(string archivo, string[] lineas);

        public string[] modificarPosicion(string archivo, string[] lineas);

        public void verArchivo(string archivo);

        public void guardarArchivo(string archivo, string[] lineas);
    }
}
