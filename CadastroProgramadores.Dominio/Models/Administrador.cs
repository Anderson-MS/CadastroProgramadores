﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroProgramadores.Dominio.Models
{
     public class Administrador 
    {
        public int AdministradorId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
