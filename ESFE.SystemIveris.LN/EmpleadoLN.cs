using System;
using System.Collections.Generic;
using System.Text;
using ESFE.SystemIveris.EN;
using ESFE.SystemIveris.DAL;

namespace ESFE.SystemIveris.LN
{
    public class EmpleadoLN
    {
        public static List<Empleado> Buscar(Empleado pEmpleado)
        {
            return EmpleadoDAL.Buscar(pEmpleado);
        }
    }
}