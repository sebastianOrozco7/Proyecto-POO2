using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.CONTROLADOR
{
    public static class DatoSesion
    {
        public static int NumeroDocumento { get; set; }
    }
}

//esta clase estatica se utiliza para que el valor del numero de documento que digite el usuario
//cuando inicia sesion se guarde aqui y pueda utilizarse en todo el programa sin cambiar su valor.
//con esto se soluciona el problema de los valores quemados.
