﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;


namespace CapaReglasNegocio
{
    public class CReglasNegocioPaciente
    {
        CDatosPaciente oDatosPaciente = new CDatosPaciente();
        public bool Guardar_Pacientes(CEntidadPaceientes ocitas)
        {
            return oDatosPaciente.Guardar_Paciente(ocitas);
        }
    }
}
