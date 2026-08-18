using System;
using System.Collections.Generic;
using System.Text;
using ESFE.SystemIveris.EN;
using ESFE.SystemIveris.DAL;

namespace ESFE.SystemIveris.LN
{
    public class EmpleadosLN
    {
        private readonly EmpleadosDAL empleadosDAL;

        public EmpleadosLN()
        {
            empleadosDAL = new EmpleadosDAL();
        }

        public bool Insertar(Empleados empleados)
        {
            return empleadosDAL.Insertar(empleados);
        }

        public bool Actualizar(Empleados empleados)
        {
            return empleadosDAL.Actualizar(empleados);
        }

        public bool Eliminar(int idEmpleado)
        {
            return empleadosDAL.Eliminar(idEmpleado);
        }

        public List<Empleados> Buscar(string criterio)
        {
            return empleadosDAL.Buscar(criterio);
        }
    }
}