﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiGmero.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}