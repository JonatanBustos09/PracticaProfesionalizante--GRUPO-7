﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_GYM_Genie.Clases
{
    public class Profesor
    {
        public int ProfesorId { get; set; }
        [MaxLength(25)]
        public int DNIProfesor { get; set; }
        [MaxLength(25)]
        public string? NombrePersona { get; set; }
        [MaxLength(25)]
        public string? ApellidoPersona { get; set; }
        [MaxLength(25)]
        public string? TelefonoPersona { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [MaxLength(50)]
        public string? CorreoElectronico { get; set; }
        [MaxLength(25)]
        public string? NombreUsuario { get; set; }
        [MaxLength(30)]
        public string? Contrasenia { get; set; }
        [MaxLength(25)]
        public string? Ciudad { get; set; }
        [MaxLength(25)]
        public string? Direccion { get; set; }
        public int AlturaDireccion { get; set; }
        public string? Titulo { get; set; }
        [MaxLength(25)]
        public string? Alias { get; set; }
        public int CBU { get; set; }
        public float Sueldo { get; set; }
    }

}
